using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Blog.ArticleCategories
{
    public class EditModel : PageModel
    {
        private readonly IArticleCategoryApplication _repository;
        [BindProperty] public EditArticleCategory Category { get; set; }
        public EditModel(IArticleCategoryApplication repository)
        {
            _repository = repository;
        }
        public void OnGet(long Id)
        {
            Category = _repository.GetValueForEdit(Id);
        }
        public RedirectToPageResult OnPost(EditArticleCategory commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./index");
        }
    }
}
