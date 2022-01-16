using Frameworks;
using SM.Application.Contracts.Order;
using SM.Domain.OrderAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IAuthHelper _authHelper;
        private readonly IOrderRepository _repository;

        public OrderApplication(IAuthHelper authHelper, IOrderRepository repository)
        {
            _authHelper = authHelper;
            _repository = repository;
        }

        public void PaymentSucceeded(long OrderId,long RefId)
        {
            var Order = _repository.GetBy(OrderId);
            Order.PaymentSuccedde(RefId);
            var Code = CodeGenerator.Generate("H");
            Order.SetCode(Code);
            _repository.Save();
        }

        public long PlaceOrder(Cart cart)
        {
            var currentUserId = _authHelper.CurrentAccountId();
            
            var Order = new OrderModel(currentUserId, cart.TotalAmount, cart.DiscountAmount, cart.PayAmount);
            foreach (var item in cart.cartItems)
            {
                var orderDetail = new OrderDetailModel(item.DiscountRate, item.Count, item.UnitPrice, item.Id);
                Order.Add(orderDetail);
            }
            _repository.Create(Order);
            _repository.Save();
            return Order.Id;
        }
    }
}
