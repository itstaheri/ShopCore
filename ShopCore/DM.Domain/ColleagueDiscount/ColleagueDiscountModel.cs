using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.ColleagueDiscount
{
    public class ColleagueDiscountModel
    {
        public ColleagueDiscountModel(long productId, int discountRate,string username)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            Username = username;
            IsRemoved = false;
        }
        public void Edit(long productId, int discountRate,string username)
        {
            ProductId = productId;
            Username = username;
            DiscountRate = discountRate;
            IsRemoved = false;
        }
        public void Removed() => IsRemoved = true;
        public void Restore() => IsRemoved = false;

        public long  Id { get; private set; }
        public string Username { get;private set; }
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public bool IsRemoved { get; private set; }
    }
}
