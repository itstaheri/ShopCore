using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.CustomerDiscount
{
    public class EditModel : PageModel
    {
        private readonly ICustomerDiscountApplication _repository;
        public List<SelectListItem> products;
        private readonly IProductApplication _products;

        public EditModel(ICustomerDiscountApplication repository, IProductApplication products)
        {
            _repository = repository;
            _products = products;
        }

        [BindProperty] public EditCustomerDiscount discount { get; set; }
        public void OnGet(long Id,SearchProduct x)
        {
            discount = _repository.GetValueForEdit(Id);
            products = _products.GetAll(x).Select(x => new SelectListItem(x.ProductName, x.ProductId.ToString())).ToList();
        }
        public void OnPost(EditCustomerDiscount commend)
        {
            _repository.Edit(commend);
            
        }
    }
}
