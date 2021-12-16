using SM.Application.Contracts.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Sliders
{
    public interface IShopSliderRepository
    {
        void Create(ShopSliderModel commend);
       
        List<ShopSliderViewModel> GetAll();
        ShopSliderModel GetById(long Id);
        void Save();
        bool Exist(long id);
        void Delete(long id);
    }
}
