using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Product
{
    public class ProductQueryModel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Picture { get; set; }
        public long CategoryId { get; set; }
        public string ShortDescription { get; set; }
        public string PictureTitle { get; set; }
        public string PictureAlt { get; set; }
        public string Price { get; set; }
        public double DoublePrice { get; set; }
        public string PriceAfterDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public bool HasDiscount { get; set; }
    }
}
