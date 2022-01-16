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
using Query.Contract.Product;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;
using SM.Infrastructure.EfCore.Permisions;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductApplication _repository;
        private readonly IProductCategoryApplication _ProductCategories;
        [BindProperty] public EditProduct Products { get; set; }
        public List<SelectListItem> Categories { get; set; }
        private readonly IProductQueryRepository _Productcatalog;
        public List<string> Catalog;
        private readonly IWebHostEnvironment _env;

        public EditModel(IProductApplication repository, IProductCategoryApplication ProductCategories ,IProductQueryRepository Productcatalog, IWebHostEnvironment env)
        {
         
            _repository = repository;
            _ProductCategories = ProductCategories;
            _Productcatalog = Productcatalog;
            _env = env;
        }
        [NeedsPermission(ShopPermission.EditProduct)]
        public void OnGet(long id, SearchProductCategoryByName commend)
        {

            Catalog = _Productcatalog.GetCatalog(id,_env.WebRootPath);

            Products = _repository.GetValueForEdit(id);
            Categories = _ProductCategories.SearchByNames(commend)
                .Select(x => new SelectListItem(x.CategoryName, x.id.ToString())).ToList();

            
        }
        
      
        public RedirectToPageResult OnPost(EditProduct commend, [FromServices] IWebHostEnvironment env)
        {

           
            _repository.Edit(commend);
            return RedirectToPage("./Index");

        }

     

    }
  
}
