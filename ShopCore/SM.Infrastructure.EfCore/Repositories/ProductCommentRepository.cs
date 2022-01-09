using Frameworks;
using Microsoft.AspNetCore.Http;
using SM.Application.Contracts.ProductComment;
using SM.Domain.ProductComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Repositories
{
    public class ProductCommentRepository : IProductCommentRepository
    {

        private readonly ShopContext _context;

        public ProductCommentRepository(ShopContext context)
        {
            _context = context;
        }

        public void Create(ProductCommentModel commend)
        {
            _context.productComments.Add(commend);
            _context.SaveChanges();
        }

        public List<ProductCommentViewModel> GetAll(ProductCommentSearchModel commend)
        {

            var query = _context.productComments.Select(x => new ProductCommentViewModel
            {
                Id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
                Status = x.Status,
                Title = x.Title,
                Username = "",
                ProductName = x.product.ProductName,
                Text = x.Text

            }).ToList();

            if (commend!=null)
            {
                if (!string.IsNullOrWhiteSpace(commend.ProductName))
                    query = query.Where(x => x.ProductName == commend.ProductName).ToList();

                if (!string.IsNullOrWhiteSpace(commend.ProductName))
                    query = query.Where(x => x.ProductName == commend.ProductName).ToList();
                
            }
            return query;
        }

        public ProductCommentModel GetBy(long Id)
        {
            return _context.productComments.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
