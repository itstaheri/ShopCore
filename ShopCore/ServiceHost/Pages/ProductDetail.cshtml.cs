using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Product;
using Query.Contract.Product.ProductComment;
using SM.Application.Contracts.ProductComment;

namespace ServiceHost.Pages
{
    public class ProductDetailModel : PageModel
    {
        private readonly IProductQueryRepository _repository;
        public ProductDetailQueryModel Product;
        public List<string> catalogNames;
        private readonly IWebHostEnvironment _env;
        private readonly IProductcommentapplication _Productcomment;
        public List<ProductCommentQueryModel> Comments;
        private readonly IProductCommentQueryRepository _ShowComments;

        public ProductDetailModel(IProductCommentQueryRepository ShowComments,IProductQueryRepository repository, IWebHostEnvironment env, IProductcommentapplication Productcomment)
        {
            _repository = repository;
            _env = env;
            _Productcomment = Productcomment;
            _ShowComments = ShowComments;
        }
        ProductCommentSearchModel NullCommend;
        public void OnGet(long id)
        {

            Product = _repository.GetDetail(id);
            catalogNames = _repository.GetCatalog(id,_env.WebRootPath);
            Comments = _ShowComments.Show(id);


        }
        public RedirectToPageResult OnPostComment(CreateProductComment commend)
        {
            _Productcomment.Create(commend);
            return RedirectToPage();
        }

    }
}
