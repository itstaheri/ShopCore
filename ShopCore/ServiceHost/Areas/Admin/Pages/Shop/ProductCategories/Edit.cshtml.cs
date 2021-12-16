using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.ProductCategories
{
    public class EditModel : PageModel
    {
        private readonly IProductCategoryApplication _repository;
        [BindProperty] public EditProductCategory productCategory { get; set; }

        public EditModel(IProductCategoryApplication repository)
        {
            _repository = repository;
        }
        public void OnGet(long id)
        {
            productCategory = _repository.GetIdForEdit(id);
        }
        public RedirectToPageResult OnPost(EditProductCategory commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");
        }
    }
}
