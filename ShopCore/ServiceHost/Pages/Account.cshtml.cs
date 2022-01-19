using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using Frameworks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    
    public class AccountModel : PageModel
    {
       
        [TempData]
        public string LoginMessage { get; set; }
        [TempData]
        public string RegisterMessage { get; set; }
        private readonly IAccountApplication _repository;
        private readonly IAuthHelper _auth;

        public AccountModel(IAccountApplication repository, IAuthHelper auth)
        {
            _repository = repository;
            _auth = auth;
        }

        public void OnGet()
        {
            if (_auth.IsAuthenticated())
            {
                RedirectToPage("./Profile");
            }
        }
        public IActionResult OnPostLogin(Login Commend)
        {
            var result = _repository.Login(Commend);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");

            }
            LoginMessage = result.Message;
            return RedirectToPage("");
        }
     
        public IActionResult OnGetLogout()
        {
            _repository.Logout();
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostRegister(Register commend)
        {
            var result =_repository.Register(commend);
            if (result.IsSuccedded)
            {
                var login = new Login
                {
                    Username = commend.Username,
                    Password = commend.Password
                };
                _repository.Login(login);
                return RedirectToPage("./Profile");
            }
            RegisterMessage = result.Message;
            return RedirectToPage("./Account");
        }
    }
}
