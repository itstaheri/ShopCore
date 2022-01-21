using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Article;

namespace ServiceHost.Pages.Blog
{
    public class ArticleDetailModel : PageModel
    {
        private readonly IArticleQueryRepository _repository;
        public ArticleDetailQueryViewModel Article;
        public ArticleDetailModel(IArticleQueryRepository repository)
        {
            _repository = repository;
        }

        public void OnGet(long Id)
        {
            Article = _repository.GetDetail(Id);
        }
    }
}
