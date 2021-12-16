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
        public long PicId { get; set; }
        public void OnGet()
        {
            Random random = new Random();
            var numb = random.Next(6543643, 954614930);
            if (_repository.Exist(PicId) == false)
            {
                PicId = long.Parse(numb.ToString());
            }
           


        }
      
        public RedirectToPageResult OnPost(CreateShopSlider commend, [FromServices] IWebHostEnvironment env)
        {
            var path = Path.Combine(env.WebRootPath, "Img", "ShopSliders");
           

            using (var stream = System.IO.File.Create(path + $"/{commend.Id}.jpg"))
            {
                commend.Picture.CopyTo(stream);
            }



            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
