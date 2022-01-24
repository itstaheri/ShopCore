using Frameworks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Product
{
    public class CreateProduct
    {
     
      //  [MaxLength(10,ErrorMessage ="Error")]
        public string ProductName { get; set; }

        //[Required]
        public string ProductCode { get;  set; }
        public string Picture { get; set; }
        public string Description { get;  set; }
        public string ShortDescription { get;  set; }
        public long QuantityInStock { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string Slug { get;  set; }
        public string Keywoard { get;  set; }
        public string MetaDescription { get;  set; }
        public long CategoryId { get;  set; }

        public string Storage { get;  set; }
        public string ScreenSize { get;  set; }
        public string NetworkSupport { get;  set; }
        public string OperatingSystem { get;  set; }
        public string Resolution { get;  set; }
        public string Ram { get;  set; }
        public string TouchId { get;  set; }

        [MaxFileSize(2048 * 1024, ErrorMessage ="حجم فایل نباید بیشتر از 2مگابایت باشد.")]
        [FileExtentionLimited(new string[] {".jpg",".jpeg",".png"},ErrorMessage ="فرمت فایل باید یکی از موارد jpg,png,jpeg باشد.")]
        public IFormFile OriginalImage { get; set; }
        public List<IFormFile> CatalogeImages { get; set; }
             
    }
}
