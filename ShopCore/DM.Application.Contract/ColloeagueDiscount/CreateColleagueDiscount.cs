using SM.Application.Contracts.Product;
using System.Collections.Generic;

namespace DM.Application.Contract.ColloeagueDiscount
{
    public class CreateColleagueDiscount
    {
        public long ProductId { get; set; }
        public int DiscountRate { get; set; }
        public string  Username { get; set; }
       // public List<ProductViewModel> products { get; set; }
    }
}
