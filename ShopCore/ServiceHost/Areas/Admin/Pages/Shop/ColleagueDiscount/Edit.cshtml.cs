using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.Contract.ColloeagueDiscount;
using DM.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.ColleagueDiscount
{
    public class EditModel : PageModel
    {
        private readonly IColleagueDiscountApplication _repository;
        public List<SelectListItem> products;
        private readonly IProductApplication _products;

        public EditModel(IColleagueDiscountApplication repository, IProductApplication products)
        {
            _repository = repository;
            _products = products;
        }

        [BindProperty] public EditColleagueDiscount discount { get; set; }
        public void OnGet(long Id,SearchProduct x)
        {
            discount = _repository.GetValueForEdit(Id);
            products = _products.GetAll(x).Select(x => new SelectListItem(x.ProductName, x.ProductId.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(EditColleagueDiscount commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");
            
        }
    }
}
