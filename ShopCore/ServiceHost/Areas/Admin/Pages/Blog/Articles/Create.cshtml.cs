using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.Article;
using BM.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Admin.Pages.Blog.Articles
{
    public class CreateModel : PageModel
    {
        private readonly IArticleApplication _repository;
        private readonly IArticleCategoryApplication _category;
        public List<SelectListItem> categories;
        public void OnGet()
        {
            categories = _category.List().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(CreateArticle commend)
        {
            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
