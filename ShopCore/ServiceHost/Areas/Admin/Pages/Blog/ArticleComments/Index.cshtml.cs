using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM.Application.Contract.ArticleComment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Blog.ArticleComments
{
    public class IndexModel : PageModel
    {
        private readonly IArticleCommentApplication _repository;
        public List<ArticleCommentViewModel> comments;
        public IndexModel(IArticleCommentApplication repository)
        {
            _repository = repository;
        }
        
        public void OnGet()
        {
            comments = _repository.List("");
        }

        public void OnPost(string Username)
        {
            comments = _repository.List(Username);
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
