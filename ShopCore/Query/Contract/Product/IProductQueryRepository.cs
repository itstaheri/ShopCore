using SM.Application.Contracts.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Product
{
    public interface IProductQueryRepository
    {
        List<ProductQueryModel> list();
        List<ProductQueryModel> Search(string commend);
        ProductDetailQueryModel GetDetail(long id);
        List<string> GetCatalog(long id,string root);
        List<CartItem> CheckInventory(List<CartItem> cartItems);

    }
}
