using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Sliders
{
    public class ShopSliderModel
    {
        public ShopSliderModel(long id,string title, string buttonText, string url,string pictureAlt, string description)
        {
            Id = id;
            Title = title;
            ButtonText = buttonText;
            Url = url;
            PictureAlt = pictureAlt;
            Description = description;

        }
        protected ShopSliderModel()
        {

        }
        public void Edit(string title,string buttonText,string url, string pictureAlt, string description)
        {
            Url = url;
            ButtonText = buttonText;
            Title = title;
            PictureAlt = pictureAlt;
            Description = description;

        }
        public long Id { get;private set; }
        public string Title { get;private set; }
        public string Description { get; private set; }
        public string ButtonText { get;private set; }
        public string Url { get;private set; }
        public string PictureAlt { get;private set; }
    }
}
