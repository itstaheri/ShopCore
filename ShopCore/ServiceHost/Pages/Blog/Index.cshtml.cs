using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Article;

namespace ServiceHost.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly IArticleQueryRepository _repository;
        public List<ArticleQueryViewModel> Articles;
        public IndexModel(IArticleQueryRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Articles = _repository.List();
        }
       
    }
}
