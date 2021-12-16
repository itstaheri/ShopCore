using Query.Contract.Slider;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Quary
{
    public class SliderQuary : ISliderQuary
    {
        private readonly ShopContext _context;

        public SliderQuary(ShopContext context)
        {
            _context = context;
        }

        public List<SliderQueryViewModel> GetAll()
        {
            return _context.shopSliders.Select(x => new SliderQueryViewModel
            {
                Id = x.Id,
                ButtonText = x.ButtonText,
                PictureAlt = x.PictureAlt,
                Title = x.Title,
                Url = x.Url,
                Description = x.Description,
                

            }).ToList();
        }
    }
}
