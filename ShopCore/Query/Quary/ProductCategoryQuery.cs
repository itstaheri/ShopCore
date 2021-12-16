using Query.Contract.Productcategory;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Quary
{
    public class ProductCategoryQuery : IProductcategoryQuery
    {
        private readonly ShopContext _context;

        public ProductCategoryQuery(ShopContext context)
        {
            _context = context;
        }

        public List<ProductCategoryQueyViewModel> GetAll()
        {
            return _context.productcategories.Where(x => x.IsDeleted == false)
                .Select(x => new ProductCategoryQueyViewModel { CategoryName = x.CategoryName, Slug = x.Slug, Id = x.Id })
                .ToList();
            
        }
    }
}
