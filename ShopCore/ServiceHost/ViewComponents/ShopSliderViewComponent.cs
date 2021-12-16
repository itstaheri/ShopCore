using Microsoft.AspNetCore.Mvc;
using Query.Contract.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class ShopSliderViewComponent : ViewComponent
    {
        private readonly ISliderQuary _Query;

        public ShopSliderViewComponent(ISliderQuary query)
        {
            _Query = query;
        }
        public IViewComponentResult Invoke()
        {
            return View(_Query.GetAll());
        }
    }
}
