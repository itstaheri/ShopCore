using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.ProductComment;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products.ProductComments
{
    public class IndexModel : PageModel
    {
        private readonly IProductcommentapplication _repository;
        public List<ProductCommentViewModel> productComments; 

        public IndexModel(IProductcommentapplication repository)
        {
            _repository = repository;
        }
        ProductCommentSearchModel nullcommend;
        public void OnGet()
        {
            productComments = _repository.List(nullcommend);
        }
        public void OnPost(ProductCommentSearchModel commend)
        {
            productComments = _repository.List(commend);
        }
        public RedirectToPageResult OnPostConfirm(long Id)
        {
            _repository.Confirm(Id);
            return RedirectToPage();
        }
        public RedirectToPageResult OnPostCancel(long Id)
        {
            _repository.Cancel(Id);
            return RedirectToPage();
        }
    }
}
