using DM.Application.Contract.CustomerDiscount;
using DM.Domain.CustomerDiscount;
using SM.Application.Contracts.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameworks;

namespace DM.infrastructure.Efcore.Repositories
{
    public class CustomerDiscountRepository : ICustomerDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly IProductApplication _Product;

        public CustomerDiscountRepository(DiscountContext context, IProductApplication Product)
        {
            _Product = Product;
            _context = context;
        }

        public void Create(CustomerDiscountModel commend)
        {
            _context.customerDiscounts.Add(commend);
            _context.SaveChanges();
        }
        SearchProduct x;
        public List<CustomerDiscountViewmodel> GetBy(SearchCustomerDiscount commend)
        {
            var product = _Product.GetAll(x).Select(x => new { x.ProductId, x.ProductName }).ToList();
            var query = _context.customerDiscounts.Select(x => new CustomerDiscountViewmodel
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                End = x.End.ToFarsi(),
                Start = x.Start.ToFarsi(),
                ProductId = x.ProductId,
                reason = x.reason,
                StartGr = x.Start,
                EndGr = x.End,
              
               
            });
            if (commend.Start != null)
            {
                query = query.Where(x => x.StartGr == commend.Start.ToGeorgianDateTime());
            }
            if (commend.End!=null)
            {
                query = query.Where(x => x.EndGr ==commend.End.ToGeorgianDateTime());
            }
             
            if (commend.ProductId>0)
            {
                query = query.Where(x => x.ProductId == commend.ProductId);
            }

            var discount = query.OrderByDescending(x => x.Id).ToList();
            discount.ForEach(discount => discount.ProductName = product
            .FirstOrDefault(x => x.ProductId==discount.ProductId)?.ProductName);

            return discount;
        }

        public CustomerDiscountModel GetById(long Id)
        {
            return _context.customerDiscounts.SingleOrDefault(x => x.Id == Id);            
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
