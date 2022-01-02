using SM.Application.Contracts.Product;
using SM.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameworks;

namespace SM.Infrastructure.EfCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopContext _context;
        public ProductRepository(ShopContext context)
        {
            _context = context;
        }
        public void Create(ProductModel commend)
        {
            _context.products.Add(commend);
            _context.SaveChanges();
        }

      

        public ProductModel GetBy(long Id)
        {
            return _context.products.SingleOrDefault(x => x.Id == Id);
        }

        public  List<ProductViewModel> GetProductsBy(SearchProduct commend)
        {
            var query = _context.products.Select(x => new ProductViewModel
            {
                CategoryName = x.productcategory.CategoryName,
                ProductCode= x.ProductCode,
                ProductId = x.Id,
                ProductName = x.ProductName,
                QuantityInStock = x.QuantityInStock,
                CreationDate = x.CreationDate.ToFarsi(),
                IsDeleted = x.IsDeleted,
                Picture = x.Picture

                
            });
            if (commend!=null)
            {
                if (!string.IsNullOrWhiteSpace(commend.Name))
                    query = query.Where(x => x.ProductName.Contains(commend.Name));
                if (!string.IsNullOrWhiteSpace(commend.Code) && commend != null)
                    query = query.Where(x => x.ProductCode.Contains(commend.Code));
            }

            return query.ToList();

            
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
