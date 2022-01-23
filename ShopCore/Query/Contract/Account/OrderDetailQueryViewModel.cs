using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Account
{
    public class OrderDetailQueryViewModel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }
    }
}
