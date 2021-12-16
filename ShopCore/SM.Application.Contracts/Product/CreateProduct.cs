using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Product
{
    public class CreateProduct
    {
     
        public string ProductName { get; set; }
        public string ProductCode { get;  set; }
        public string Description { get;  set; }
        public string ShortDescription { get;  set; }
        public long QuantityInStock { get;  set; }
        public double Price { get;  set; }       
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string Slug { get;  set; }
        public string Keywoard { get;  set; }
        public string MetaDescription { get;  set; }
        public long CategoryId { get;  set; }

        public string Storage { get;  set; }
        public float ScreenSize { get;  set; }
        public string NetworkSupport { get;  set; }
        public string OperatingSystem { get;  set; }
        public int Resolution { get;  set; }
        public int Ram { get;  set; }
        public string TouchId { get;  set; }

        public IFormFile OriginalImage { get; set; }
        public List<IFormFile> CatalogeImages { get; set; }
             
    }
}
