using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Frameworks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;
using SM.Infrastructure.EfCore.Permisions;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> ProductCategories { get; set; }
        private readonly IProductCategoryApplication _productCategory;
        private readonly IProductApplication _repository;
        public CreateProduct product;

        public CreateModel(IProductApplication repository, IProductCategoryApplication productCategory)
        {
            _repository = repository;
            _productCategory = productCategory;
        }
        [NeedsPermission(ShopPermission.ActiveOrDeactiveProductComment)]
        public void OnGet(SearchProductCategoryByName commend)
        {

            ProductCategories = _productCategory.SearchByNames(commend).Select(x => new SelectListItem(x.CategoryName, x.id.ToString())).ToList();
        }
        [NeedsPermission(ShopPermission.CreateProduct)]
        public IActionResult OnPost(CreateProduct commend)
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}


            _repository.Create(commend);
            return RedirectToPage("./Index");


        }
    }
}
