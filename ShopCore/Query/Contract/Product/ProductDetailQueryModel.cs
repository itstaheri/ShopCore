using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Product
{
    public class ProductDetailQueryModel
    {
        public long Id { get;  set; }
        public string ProductName { get;  set; }
        public string ProductCode { get;  set; }
        public string Picture { get; set; }
        public string Description { get;  set; }
        public string ShortDescription { get;  set; }
        public long QuantityInStock { get;  set; }
        public bool IsDeleted { get;  set; }
        public DateTime CreationDate { get;  set; }

        public string Storage { get;  set; }
        public float ScreenSize { get;  set; }
        public string NetworkSupport { get;  set; }
        public string OperatingSystem { get;  set; }
        public int Resolution { get;  set; }
        public int Ram { get;  set; }
        public string TouchId { get;  set; }


        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string Slug { get;  set; }
        public string Keywoard { get;  set; }
        public string MetaDescription { get;  set; }

        public long CategoryId { get;  set; }

        public string CategoryName { get; set; }
        public string Price { get; set; }
        public double DoublePrice { get; set; }
        public int discountRate { get; set; }
        public string PriceAfterDiscount { get; set; }


    }
}
