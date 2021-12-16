using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Slider
{
    public class CreateShopSlider
    {
        public long Id { get; set; }
        public IFormFile Picture { get; set; } 
        public string Title { get;  set; }
        public string ButtonText { get;  set; }
        public string Url { get;  set; }
        public string PictureAlt { get;  set; }
        public string Description { get; set; }

    }
}
