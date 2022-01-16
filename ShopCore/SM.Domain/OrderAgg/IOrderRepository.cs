using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.OrderAgg
{
    public interface IOrderRepository
    {
        void Create(OrderModel order);
        void Save();
        OrderModel GetBy(long Id);
    }
}
