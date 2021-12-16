using SM.Application.Contracts.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Product
{
    public interface IProductRepository
    {
        void Create(ProductModel commend);
        List<ProductViewModel> GetProductsBy(SearchProduct commend);
        ProductModel GetBy(long Id);
        void Save();
       

    }
}
