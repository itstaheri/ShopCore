using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.ArticleCategory;

namespace ServiceHost.Pages.Blog
{
    public class CategoryModel : PageModel
    {
        private readonly IArticleCategoryQueryRepository _repository;
        public List<ArticleCategoryQueryViewModel> categories;
        public CategoryModel(IArticleCategoryQueryRepository repository)
        {
            _repository = repository;
        }

        public void OnGet(long CategoryId)
        {
            categories = _repository.GetProductsWithCategory(CategoryId);
        }
    }
}
