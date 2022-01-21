using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Blog.ArticleCategories
{

    public class IndexModel : PageModel
    {
        private readonly IArticleCategoryApplication _repository;
        public List<ArticleCategoryViewModel> articleCategories;

        public IndexModel(IArticleCategoryApplication repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            articleCategories = _repository.List();
        }
        public RedirectToPageResult OnPostActive(long Id)
        {
            _repository.Active(Id);
            return RedirectToPage();
        }
        public RedirectToPageResult OnPostRemove(long Id)
        {
            _repository.remove(Id);
            return RedirectToPage();
        }
    }
    
}
