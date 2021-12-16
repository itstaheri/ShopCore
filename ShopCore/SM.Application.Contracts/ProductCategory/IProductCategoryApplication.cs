using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        void Create(CreateProductCategory commend);
        void Edit(EditProductCategory commend);
        EditProductCategory GetIdForEdit(long id);
        List<ProductCategoryViewModel> SearchByNames(SearchProductCategoryByName commend);
        ProductCategoryViewModel GetBy(long id);
        void Delete(long id);
        void Active(long id);
    
    }
}
