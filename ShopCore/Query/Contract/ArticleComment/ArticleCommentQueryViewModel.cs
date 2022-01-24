using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.ArticleComment
{
    public class ArticleCommentQueryViewModel
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public long ArticleId { get; set; }
    }
}
