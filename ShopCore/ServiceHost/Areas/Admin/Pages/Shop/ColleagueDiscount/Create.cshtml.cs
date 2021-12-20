using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application;
using DM.Application.Contract.ColloeagueDiscount;
using DM.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.ColleagueDiscount
{
    public class CreateModel : PageModel
    {
        private readonly IColleagueDiscountApplication _repository;
        public List<SelectListItem> products;
        private readonly IProductApplication _products;

        public CreateModel(IColleagueDiscountApplication repository, IProductApplication products)
        {
            _repository = repository;
            _products = products;
        }

        public void OnGet(SearchProduct x)
        {
          
            products = _products.GetAll(x).Select(x => new SelectListItem(x.ProductName, x.ProductId.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(CreateColleagueDiscount commend)
        {
            _repository.Create(commend);
            return RedirectToPage("./Index");

        }
    }
}
