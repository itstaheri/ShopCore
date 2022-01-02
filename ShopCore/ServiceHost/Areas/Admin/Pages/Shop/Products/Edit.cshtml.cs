using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductApplication _repository;
        private readonly IProductCategoryApplication _ProductCategories;
        [BindProperty] public EditProduct Products { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public List<CatalogeModel> cataloges { get; set; }

        public EditModel(IProductApplication repository, IProductCategoryApplication ProductCategories)
        {
         
            _repository = repository;
            _ProductCategories = ProductCategories;
        }

        public void OnGet(long id, SearchProductCategoryByName commend)
        {

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
    public class CatalogeModel
    {
    }
}
