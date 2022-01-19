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
    public class CreateModel : PageModel
    {
        private readonly IShopSliderApplication _repository;

        public CreateModel(IShopSliderApplication repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
           


        }
      
        public RedirectToPageResult OnPost(CreateShopSlider commend)
        {
            

            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
