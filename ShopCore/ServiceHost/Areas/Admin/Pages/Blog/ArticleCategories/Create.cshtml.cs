using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Blog.ArticleCategories
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _repository;

        public CreateModel(IArticleCategoryApplication repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticleCategory commend)
        {
            _repository.Create(commend);
            return RedirectToPage("./index");
        }
    }
}
