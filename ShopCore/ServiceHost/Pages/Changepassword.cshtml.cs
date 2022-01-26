using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    [Authorize]
    public class ChangepasswordModel : PageModel
    {
        private readonly IAccountApplication _repository;

        public ChangepasswordModel(IAccountApplication repository)
        {
            _repository = repository;
        }
        public long AccountId;
     
        public void OnGet(long Id)
        {
            AccountId = Id;
        }
        public RedirectToPageResult OnPost(ChangePasswordModel commend)
        {
            if (ModelState.IsValid)
            {
                
            }
            _repository.UserChangePassword(commend);
            _repository.Logout();
            return RedirectToPage("./Account");
        }
    }
}
