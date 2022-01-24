using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.ArticleComment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Article;
using Query.Contract.ArticleCategory;
using Query.Contract.ArticleComment;

namespace ServiceHost.Pages.Blog
{
    public class ArticleDetailModel : PageModel
    {
        private readonly IArticleQueryRepository _repository;
        private readonly IArticleCommentsQueryRepository _comment;
        private readonly IArticleCommentApplication _createcomment;
        private readonly IArticleCategoryQueryRepository _related;
        public ArticleDetailQueryViewModel Article;
        public List<ArticleCommentQueryViewModel> comments;
        public List<ArticleCategoryQueryViewModel> RealtedArticles;
        public ArticleDetailModel(IArticleCategoryQueryRepository related,IArticleQueryRepository repository, IArticleCommentsQueryRepository comment, IArticleCommentApplication createcomment)
        {
            _repository = repository;
            _comment = comment;
            _createcomment = createcomment;
            _related = related;
        }
      
        public void OnGet(long Id)
        {
           
            Article = _repository.GetDetail(Id);
            comments = _comment.Show(Id);
            RealtedArticles = _related.GetProductsWithCategory(Article.CategoryId);
        }
        public RedirectToPageResult OnPost(CreateArticleComment commend)
        {
            _createcomment.Create(commend);
           return RedirectToPage();
        }
    }
}
