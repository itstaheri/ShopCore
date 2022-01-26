using AM.Infrastracture.Efcore;
using Microsoft.EntityFrameworkCore;
using SM.Application.Contracts.Order;
using SM.Domain.OrderAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AccountContext _account;
        private readonly ShopContext _context;

        public OrderRepository(ShopContext context, AccountContext account)
        {
            _context = context;
            _account = account;
        }

        public void Create(OrderModel order)
        {
            _context.orders.Add(order);
            _context.SaveChanges();
        }

        public OrderModel GetBy(long Id)
        {
            return _context.orders.SingleOrDefault(x => x.Id == Id);
        }

        public List<OrderViewmodel> GetOrders(OrderSearchModel commend)
        {
            
            var query =  _context.orders.Select(x => new OrderViewmodel
            {
                Id = x.Id,
                UserId = x.UserId,
                Status = x.Status,
                cartItems = MappCartitems(x.orderDetails),
                Code = x.Code,
                OrderDate = x.OrderDate,
                PayAmount = x.PayAmount,
                CustomerDescription = x.CustomerDescription,
                IsFinaly = x.IsFinaly,
                PaymentMethod = x.PaymentMethod,
                Description = x.CustomerDescription
            }).AsNoTracking().ToList();

            foreach (var item in query)
            {
                var account = _account.accounts.SingleOrDefault(x => x.Id == item.UserId);
                item.Username = account.Username;
            }
            if (commend!=null)
            {
                if (!string.IsNullOrWhiteSpace(commend.Code))
                    query=  query.Where(x => x.Code == commend.Code).ToList();

                if (!string.IsNullOrWhiteSpace(commend.Username))
                    query=  query.Where(x => x.Username == commend.Username).ToList();

                if (commend.Status != null && commend.Status > 0)
                    query = query.Where(x => x.Status == commend.Status).ToList();

            }
            return query;
        }

        private static List<CartItem> MappCartitems(List<OrderDetailModel> orderDetails)
        {
            var query = orderDetails.Select(x => new CartItem
            {
                Count = x.Count,
                UnitPrice = x.UnitPrice,
                TotalPrice = x.TotalPrice,
                Id = x.ProductId,

         
            }).ToList();
          
            return query;
        }

        public double GetPayPrice(long Id)
        {
            var order =  _context.orders.Select(x => new { x.Id, x.PayAmount }).FirstOrDefault(x => x.Id == Id).PayAmount;
            return order != null ? order : 0;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void RemoveOrder(long Id)
        {
           var order = _context.orders.SingleOrDefault(x => x.Id == Id);
            _context.Remove(order);
            _context.SaveChanges();
        }
    }
}
