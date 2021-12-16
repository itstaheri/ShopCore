using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application.Contract.CustomerDiscount
{
    public class CustomerDiscountViewmodel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
        public int DiscountRate { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string reason { get; set; }
        public DateTime StartGr { get; set; }
        public DateTime EndGr { get; set; }

    }
}
