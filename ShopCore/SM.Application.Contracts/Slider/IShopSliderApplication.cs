using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Slider
{
    public interface IShopSliderApplication
    {
        void Create(CreateShopSlider commend);
        List<ShopSliderViewModel> List();
        EditShopSlider GetValueForEdit(long id);
        void Edit(EditShopSlider commend);
        bool Exist(long id);
        void Delete(long id);
    }
}
