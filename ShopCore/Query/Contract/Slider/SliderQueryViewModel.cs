using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Slider
{
    public class SliderQueryViewModel
    {
        public long Id { get; set; }
        public string Title { get;  set; }
        public string Description { get; set; }
        public string ButtonText { get;  set; }
        public string Url { get;  set; }
        public string PictureAlt { get;  set; }
    }
}
