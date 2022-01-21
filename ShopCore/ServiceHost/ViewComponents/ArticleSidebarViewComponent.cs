using Microsoft.AspNetCore.Mvc;
using Query.BlogQuery;
using Query.Contract.Article;
using Query.Contract.ArticleCategory;
using Query.Contract.ArticleComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class ArticleSidebarViewComponent : ViewComponent
    {
        private readonly IArticleQueryRepository _article;
        private readonly IArticleCategoryQueryRepository _category;
        private readonly IArticleCommentsQueryRepository _comment;
        public ArticleSidebarViewModel Model { get; set; }

        public ArticleSidebarViewComponent(IArticleQueryRepository article, IArticleCategoryQueryRepository category, IArticleCommentsQueryRepository comment)
        {
            _article = article;
            _category = category;
            _comment = comment;
        }

        public IViewComponentResult Invoke()
        {
            Model.articles = _article.List(); 
            Model.comments = _comment.GetAll();
            Model.categories = _category.GetAll();

            return View(Model);

            
        }
    }
}
