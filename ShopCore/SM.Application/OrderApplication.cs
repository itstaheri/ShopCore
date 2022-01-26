using Frameworks;
using Frameworks.Sms;
using IM.Application.Contract.Inventory;
using IM.Domain.Inventory;
using Microsoft.EntityFrameworkCore;
using SM.Application.Contracts.Order;
using SM.Domain.OrderAgg;
using SM.Infrastructure.EfCore;
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
        private readonly IInventoryRepository _inventory;
        private readonly ShopContext _shop;
        private readonly ISmsService _smsService;

        public OrderApplication(ISmsService smsService,ShopContext shop, IAuthHelper authHelper, IOrderRepository repository, IInventoryRepository inventory)
        {
            _authHelper = authHelper;
            _repository = repository;
            _inventory = inventory;
            _shop = shop;
            _smsService = smsService;
        }

        public double GetAmountBy(long Id)
        {
            return _repository.GetPayPrice(Id);
        }
        SearchInventory nullmodel;
        public string PaymentSucceeded(long OrderId, long RefId)
        {
            #region Reduce
            var order = _repository.GetBy(OrderId);
            //foreach (var q in order.orderDetails)
            //{
            //    var InventoryOperatin   = _inventory.GetBy(q.Id).inventoryOperations;

            //    foreach (var x in InventoryOperatin)
            //    {
            //        x.ReduceAfterPay(q.Count);
            //        _inventory.Save();
            //    }
                
        

            //}
            #endregion

            var Order = _repository.GetBy(OrderId);
            Order.PaymentSuccedde(RefId);
            var Code = CodeGenerator.Generate("H");
            Order.SetCode(Code);
            _repository.Save();

            var GetUserNumber = _authHelper.CurrentAccountInfo();
            _smsService.Sendsms(GetUserNumber.Number,SmS.OrderSuccess+Code);

            return Code;
        }

        public long PlaceOrder(Cart cart)
        {
            var currentUserId = _authHelper.CurrentAccountId();

            var Order = new OrderModel(currentUserId, cart.TotalAmount, cart.DiscountAmount, cart.PayAmount, cart.PaymentMethod, cart.CustomerDescription);
            foreach (var item in cart.cartItems)
            {
                var orderDetail = new OrderDetailModel(item.DiscountRate, item.Count, item.UnitPrice, item.Id);
                Order.Add(orderDetail);
            }
            _repository.Create(Order);
            _repository.Save();
            return Order.Id;
        }

        public List<OrderViewmodel> GetOrders(OrderSearchModel commend)
        {
            return _repository.GetOrders(commend);
        }

        public void ChangeStatusToPending(long OrderId)
        {
            var Order = _repository.GetBy(OrderId);
            Order.Pending_status();
            _repository.Save();
        }

        public void ChangeStatusToSended(long OrderId)
        {
            var Order = _repository.GetBy(OrderId);
            Order.Sended_status();
            _repository.Save();
        }

        public void ChangeStatusToCanceled(long OrderId)
        {
            _repository.RemoveOrder(OrderId);
        }

        public List<OrderDetailViewModel> GetOrderdetail(long orderId)
        {

            var query = _shop.orders.FirstOrDefault(x => x.Id == orderId).orderDetails.Select(x => new OrderDetailViewModel
            {
                Id = x.Id,
                Count = x.Count,
                ProductId = x.ProductId,
                TotalPrice = x.TotalPrice,
                UnitPrice = x.UnitPrice,

            }).ToList();

            foreach (var item in query)
            {
                var product = _shop.products.FirstOrDefault(x => x.ProductId == item.ProductId);
                item.ProductName = product.ProductName;
                item.Picture = product.Picture;

            }
            return query;

        }
    }
}
