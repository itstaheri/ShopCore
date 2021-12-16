using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.CustomerDiscount
{
    public class CustomerDiscountModel
    {
        protected CustomerDiscountModel()
        {

        }
        public CustomerDiscountModel(long productId, int discountRate, DateTime start, DateTime end, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            Start = start;
            End = end;
            this.reason = reason;
        }
        public void Edit(long productId, int discountRate, DateTime start, DateTime end, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            Start = start;
            End = end;
            this.reason = reason;
        }
        public long Id { get; set; }
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public string reason { get;private set; }
    }
}
