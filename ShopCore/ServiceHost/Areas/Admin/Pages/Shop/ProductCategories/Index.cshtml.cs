using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.ProductCategoires
{
    public class IndexModel : PageModel
    {
        private readonly IProductCategoryApplication _repository;
        public List<ProductCategoryViewModel> productCategories; 
        public IndexModel(IProductCategoryApplication repository)
        {
            _repository = repository;
        }
        public void OnGet(SearchProductCategoryByName searchModel)
        {
            productCategories = _repository.SearchByNames(searchModel);
        }
        public void OnPost(SearchProductCategoryByName searchModel)
        {
            productCategories = _repository.SearchByNames(searchModel);
           
        }
        public RedirectToPageResult OnPostDeleted(long Id)
        {
            _repository.Delete(Id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnPostActive(long Id)
        {
            _repository.Active(Id);
            return RedirectToPage("./Index");
        }
    }
}
