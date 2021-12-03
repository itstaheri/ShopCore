using SM.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductCategory
{
    public interface IProductCategoryRepository
    {
        void Create(ProductCategoryModel productCategory);
        List<ProductCategoryModel> GetAll();
        ProductCategoryModel Get(long id);
        bool ExistByName(string Name);
        List<ProductCategoryViewModel> SearchByNames(SearchProductCategoryByName commend);
        void Save();    
    }
}
