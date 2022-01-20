using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Blog.Articles
{
    public class IndexModel : PageModel
    {
        private readonly IArticleApplication _repository;
        public List<ArticleViewModel> articles;
        public IndexModel(IArticleApplication repository)
        {
            _repository = repository;
        }
        ArticleSearchModel Isnull;
        public void OnGet()
        {
            articles = _repository.List(Isnull);
        }
        public void OnPost(ArticleSearchModel commend)
        {
            articles = _repository.List(commend);
        }
        public RedirectToPageResult OnPostActive(long Id)
        {
            _repository.Active(Id);
            return RedirectToPage();
        }
        public RedirectToPageResult OnPostRemove(long Id)
        {
            _repository.Remove(Id);
            return RedirectToPage();
        }
    }
}
