using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.Contract.ColloeagueDiscount;
using DM.Application.Contract.CustomerDiscount;
using DM.Domain.ColleagueDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Shop.ColleagueDiscount
{
    public class IndexModel : PageModel
    {
        private readonly IColleagueDiscountApplication _repository;
        public List<ColleagueDiscountViewModel> discounts;

        public IndexModel(IColleagueDiscountApplication repository)
        {
            _repository = repository;
        }

        public void OnGet(SearchColleagueDiscount x)
        {
            discounts = _repository.GetAll(x);
        }
        public void OnPost(SearchColleagueDiscount x)
        {
            discounts = _repository.GetAll(x);
        }
        public RedirectToPageResult OnPostDelete(long Id)
        {
            _repository.IsRemoved(Id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnPostActive(long Id)
        {
            _repository.IsRestore(Id);
            return RedirectToPage("./Index");
        }
    }
}
