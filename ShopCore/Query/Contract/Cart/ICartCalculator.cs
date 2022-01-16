using SM.Application.Contracts.Order;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Cart
{
    public interface ICartCalculator
    {
        SM.Application.Contracts.Order.Cart ComputeCart(List<CartItem> cartItems);
    }
}
