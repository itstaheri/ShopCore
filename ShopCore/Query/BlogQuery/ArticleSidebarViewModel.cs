using Query.Contract.Article;
using Query.Contract.ArticleCategory;
using Query.Contract.ArticleComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.BlogQuery
{
    public class ArticleSidebarViewModel
    {
        public List<ArticleCommentQueryViewModel> comments { get; set; }
        public List<ArticleQueryViewModel> articles { get; set; }
        public List<ArticleCategoryQueryViewModel> categories { get; set; }
}
}
