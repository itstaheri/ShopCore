using BM.Application.Contract.Article;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly IArticleApplication _repository;
        public List<ArticleViewModel> articles;

        public BlogViewComponent(IArticleApplication repository)
        {
            _repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            articles = _repository.List(null);
            return View(articles);
        }
    }
}
