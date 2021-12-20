using SM.Domain.Product;
using System.Collections.Generic;

namespace DM.Application.Contract.ColloeagueDiscount
{
    public class ColleagueDiscountViewModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public long ProductId { get; set; }
        public int Discountrate { get; set; }
        public string ProductName { get; set; }
        public bool IsRemoved { get; set; }
        public List<ProductModel> products { get; set; }

    }
}
 