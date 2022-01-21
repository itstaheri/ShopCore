using BM.Domain.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Query.Contract.ArticleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class ArticleCategoryViewComponent :ViewComponent
    {
        private readonly IArticleCategoryQueryRepository _repository;

        public ArticleCategoryViewComponent(IArticleCategoryQueryRepository repository)
        {
            _repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_repository.GetAll());
        }
    }
}
