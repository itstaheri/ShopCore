using DM.Application.Contract.ColloeagueDiscount;
using DM.Domain.ColleagueDiscount;
using SM.Application.Contracts.Product;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.infrastructure.Efcore.Repositories
{
    public class ColleagueDiscountRepository : IColleagueDiscountRepository
    {
        private readonly DiscountContext _context;
       
        private readonly ShopContext _product;
        public ColleagueDiscountRepository(DiscountContext context, ShopContext product)
        {
            _context = context;
            _product = product;
        }

        public void Create(ColleagueDiscountModel commend)
        {
            _context.colleagueDiscounts.Add(commend);
            _context.SaveChanges();
        }

        
        public List<ColleagueDiscountViewModel> GetAllBy(SearchColleagueDiscount commend)
        {

            var product = _product.products.Select(x => new { x.Id, x.ProductName }).ToList();
            
            var query = _context.colleagueDiscounts.Select(x => new ColleagueDiscountViewModel
            {
                Id = x.Id,
                Discountrate = x.DiscountRate,
                ProductId = x.ProductId,
                //ProductName = product.SingleOrDefault(q => q.Id == x.ProductId).ProductName,
                IsRemoved = x.IsRemoved
            });
            
            if (!string.IsNullOrWhiteSpace(commend.UserName))
            {
                query = query.Where(x => x.Username == commend.UserName);
            }
            if (commend.ProductId > 0)
            {
                query = query.Where(x => x.ProductId == commend.ProductId);
            }
            var discount = query.OrderByDescending(x => x.Id).ToList();
            discount.ForEach(discount => discount.ProductName = product.FirstOrDefault(x => x.Id == discount.ProductId)?.ProductName);

            return discount;
        }

        public ColleagueDiscountModel GetBy(long Id)
        {
            return _context.colleagueDiscounts.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
