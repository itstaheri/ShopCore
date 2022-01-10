using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Shop.Accounts
{
    public class ChangePasswordModel : PageModel
    {
        private readonly IAccountApplication _repository;

        public ChangePasswordModel(IAccountApplication repository)
        {
            _repository = repository;
        }
        public long AId;
        public void OnGet(long Id)
        {
            AId = Id;
        }
        
        public RedirectToPageResult OnPost(AM.Application.Contract.Account.ChangePasswordModel commend)
        {
            _repository.ChangePassword(commend);
            return RedirectToPage("./Index");
        }
    }
}
