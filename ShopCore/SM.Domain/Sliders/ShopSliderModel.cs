using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Sliders
{
    public class ShopSliderModel
    {
        public ShopSliderModel(long id,string title, string buttonText, string url,string pictureAlt, string description,string picture)
        {
            Id = id;
            Title = title;
            ButtonText = buttonText;
            Url = url;
            PictureAlt = pictureAlt;
            Description = description;
            if (!string.IsNullOrEmpty(picture))
                Picture = picture;


        }
        protected ShopSliderModel()
        {

        }
        public void Edit(string title,string buttonText,string url, string pictureAlt, string description,string picture)
        {
            Url = url;
            ButtonText = buttonText;
            Title = title;
            PictureAlt = pictureAlt;
            Description = description;
            if (!string.IsNullOrEmpty(picture))
                Picture = picture;


        }
        [Key]
        public long Id { get;private set; }
        public string Title { get;private set; }
        public string Picture { get;private set; }
        public string Description { get; private set; }
        public string ButtonText { get;private set; }
        public string Url { get;private set; }
        public string PictureAlt { get;private set; }
    }
}
