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

        private readonly ShopContext _context;
        public void Create(OrderModel order)
        {
            _context.orders.Add(order);
            _context.SaveChanges();
        }

        public OrderModel GetBy(long Id)
        {
            return _context.orders.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
