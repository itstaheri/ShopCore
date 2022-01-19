using Frameworks;
using SM.Application.Contracts.Slider;
using SM.Domain.Sliders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application
{
    public class ShopSliderApplication : IShopSliderApplication
    {
        private readonly IShopSliderRepository _repository;
        private readonly IFileUploader _Uploader;
        public ShopSliderApplication(IShopSliderRepository repository, IFileUploader Uploader)
        {
            _repository = repository;
            _Uploader = Uploader;
        }

        public void Create(CreateShopSlider commend)
        {
            var PictureName = _Uploader.Upload(commend.Picture, "Shopsliders",commend.Id.ToString());
            
            var Slider = new ShopSliderModel(commend.Id,commend.Title, commend.ButtonText, commend.Url, commend.PictureAlt,commend.Description,PictureName);
            _repository.Create(Slider);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
           
          
        }

        public void Edit(EditShopSlider commend)
        {
            var PictureName = _Uploader.Upload(commend.Picture, "Shopsliders", commend.Id.ToString());
            var Slider = _repository.GetById(commend.Id);
            Slider.Edit(commend.Title, commend.ButtonText, commend.Url, commend.PictureAlt, commend.Description, PictureName);
            _repository.Save();
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public EditShopSlider GetValueForEdit(long id)
        {
            var Value = _repository.GetById(id);
            return new EditShopSlider
            {
                Id = Value.Id,
                ButtonText = Value.ButtonText,
                PictureAlt = Value.PictureAlt,
                Title = Value.Title,
                Url = Value.Url,
                
            };
        }

        public List<ShopSliderViewModel> List()
        {
           return _repository.GetAll();
        }
    }
}
