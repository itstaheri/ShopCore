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
    public class EditModel : PageModel
    {
        private readonly IArticleApplication _repository;
        private readonly IArticleCategoryApplication _category;
        public List<SelectListItem> categories;
        [BindProperty] public EditArticle Article { get; set; }

        public EditModel(IArticleApplication repository, IArticleCategoryApplication category)
        {
            _repository = repository;
            _category = category;
           
        }

     
        public void OnGet(long Id)
        {
            Article = _repository.GetValueforEdit(Id);
            categories = _category.List().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(EditArticle commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");

        }
    }
}
