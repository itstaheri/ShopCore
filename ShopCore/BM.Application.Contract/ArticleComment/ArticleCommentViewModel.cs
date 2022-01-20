using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.ArticleComment
{
    public class ArticleCommentViewModel
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string Text { get; set; }
        public string CreateDate { get; set; }
        public string Username { get; set; }
        public long ArticleId { get; set; }
        public string ArticleName { get; set; }
    }
}
