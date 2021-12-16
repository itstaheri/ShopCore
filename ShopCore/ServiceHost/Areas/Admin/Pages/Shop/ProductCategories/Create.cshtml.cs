using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.ProductCategories
{
    public class CreateModel : PageModel
    {
        public CreateProductCategory Pcategory { get; set; }
        private readonly IProductCategoryApplication _repository;
        public CreateModel(IProductCategoryApplication repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            
        }
        public RedirectToPageResult OnPost(CreateProductCategory commend)
        {
            
            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
