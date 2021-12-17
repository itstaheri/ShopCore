using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Shop.CustomerDiscount
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerDiscountApplication _repository;
        public List<CustomerDiscountViewmodel> discounts;

        public IndexModel(ICustomerDiscountApplication repository)
        {
            _repository = repository;
        }

        public void OnGet(SearchCustomerDiscount x)
        {
            discounts = _repository.GetAll(x);
        }
        public void OnPost(SearchCustomerDiscount x)
        {
            discounts = _repository.GetAll(x);
        }
    }
}
