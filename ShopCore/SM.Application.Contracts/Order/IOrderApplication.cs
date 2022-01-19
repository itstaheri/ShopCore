using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Order
{
    public interface IOrderApplication
    {
        long PlaceOrder(Cart cart);
        string PaymentSucceeded(long OrderId,long RefId);
        double GetAmountBy(long Id);
        List<OrderViewmodel> GetOrders(OrderSearchModel commend);
        OrderDetailViewModel GetOrderdetail(long orderId);
        void ChangeStatusToPending(long OrderId);
        void ChangeStatusToSended(long OrderId);
        void ChangeStatusToCanceled(long OrderId);
    }
}
