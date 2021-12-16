using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application.Contract.CustomerDiscount
{
    public class CreateCustomerDiscount
    {
        public long ProductId { get; set; }
        public int DiscountRate { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string reason { get; set; }
    }
}
