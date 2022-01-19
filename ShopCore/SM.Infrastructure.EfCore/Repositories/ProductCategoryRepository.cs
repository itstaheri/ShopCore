using SM.Application.Contracts.ProductCategory;
using SM.Domain.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameworks;
namespace SM.Infrastructure.EfCore.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ShopContext _context;

        public ProductCategoryRepository(ShopContext context)
        {
            _context = context;
        }

        public void Create(ProductCategoryModel productCategory)
        {
            _context.productcategories.Add(productCategory);
            _context.SaveChanges();
        }

        public bool ExistByName(string Name)
        {
            var result = _context.productcategories.Any(x => x.CategoryName == Name);
            return result;
        }

        public ProductCategoryModel Get(long id)
        {
            var ProductCategory = _context.productcategories.SingleOrDefault(x => x.Id == id);
            return ProductCategory;
        }

        public List<ProductCategoryModel> GetAll()
        {
            return _context.productcategories.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<ProductCategoryViewModel> SearchByNames(SearchProductCategoryByName commend)
        {
            var query = _context.productcategories.Select(x => new ProductCategoryViewModel
            {
                id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
                CategoryName = x.CategoryName,
                Slug = x.Slug,
                Isdeleted = x.IsDeleted,
                ProductCount = x.products.Count()

                
            });
            if (commend!=null)
            {
                if (!string.IsNullOrEmpty(commend.Name))
                    query = query.Where(x => x.CategoryName.Contains(commend.Name));
            }
            
          
            
            return query.OrderByDescending(x => x.id).ToList();

        }
    }
}
