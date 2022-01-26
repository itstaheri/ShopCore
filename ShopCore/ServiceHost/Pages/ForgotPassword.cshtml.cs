using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using AM.Domain.AccountAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly IAccountApplication _repository;
        private readonly IAccountRepository _Exist;

        public ForgotPasswordModel(IAccountApplication repository, IAccountRepository Exist)
        {
            _repository = repository;
            _Exist = Exist;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(string Email)
        {
            
            _repository.ForgotPassword(Email);
            return RedirectToPage("/Result","OnGet",new {Message= "در صورت صحیح بودن ایمیل وارد شده رمز بازیابی رمزعبور به ایمیل شما ارسال شده است." });
        }
    
            
    }
}

