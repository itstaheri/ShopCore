using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.Slider;

namespace ServiceHost.Areas.Admin.Pages.Shop.Sliders.ShopSlider
{
    public class IndexModel : PageModel
    {
        private readonly IShopSliderApplication _repository;
        public List<ShopSliderViewModel> sliders { get; set; }
        public IndexModel(IShopSliderApplication repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
          sliders =  _repository.List();
        }
        public RedirectToPageResult OnPost(long Id,string Title,[FromServices] IWebHostEnvironment env)
        {
            System.IO.File.Delete(Path.Combine(env.WebRootPath,"Img","Shopsliders",Title));
            _repository.Delete(Id);
           
            return RedirectToPage();
        }
    }
}
