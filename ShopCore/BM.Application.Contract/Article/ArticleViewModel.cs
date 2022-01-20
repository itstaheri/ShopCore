using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.Article
{
    public class ArticleViewModel
    {
        public long Id { get;  set; }
        public string Title { get;  set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string ShortDescription { get;  set; }
        public string Description { get;  set; }
        public bool IsRemoved { get;  set; }
        public string CreationDate { get;  set; }
        public string Username { get;  set; }
        public string CategoryName { get;  set; }
        public long CategoryId { get;  set; }
    }
}
