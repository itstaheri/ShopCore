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
    public class EditModel : PageModel
    {

        private readonly IShopSliderApplication _repository;
        [BindProperty] public EditShopSlider Slider { get; set; }
        public EditModel(IShopSliderApplication repository)
        {
            _repository = repository;
        }
        public void OnGet(long id)
        {
            Slider = _repository.GetValueForEdit(id);
        }
        public RedirectToPageResult OnPost(EditShopSlider commend)
        {
          

            _repository.Edit(commend);
            return RedirectToPage("./Index");
        }
    }
}
