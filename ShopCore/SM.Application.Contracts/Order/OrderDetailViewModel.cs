using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Order
{
    public class OrderDetailViewModel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string Picture { get; set; }
        public int Count { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
       
    }
}
