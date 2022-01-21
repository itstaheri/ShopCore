using Query.Contract.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.ArticleCategory
{
    public class ArticleCategoryQueryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<ArticleQueryViewModel> articles { get; set; }
    }
}
