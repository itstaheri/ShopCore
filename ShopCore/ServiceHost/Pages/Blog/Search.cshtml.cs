using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Article;

namespace ServiceHost.Pages.Blog
{
    public class SearchModel : PageModel
    {
        private readonly IArticleQueryRepository _repository;
        public List<ArticleQueryViewModel> Articles;
        public SearchModel(IArticleQueryRepository repository)
        {
            _repository = repository;

        }
        public string value;
        public void OnGet(string commend)
        {
            value = commend;
            Articles = _repository.Search(commend);
        }
    }
}
