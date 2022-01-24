using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using Frameworks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Account;

namespace ServiceHost.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IAccountQueryRepository _repository;
        private readonly IAccountApplication _account;

        public AccountQueryViewModel Account;
        public AddressQueryViewModel Address;
        [BindProperty] public EditAccount AccountInfo { get; set; }

        private readonly IAuthHelper _auth;
        public long RoleId;
        public ProfileModel(IAccountQueryRepository repository, IAuthHelper auth, IAccountApplication account)
        {
            _repository = repository;
            _auth = auth;
            _account = account;
        }

        public void OnGet()
        {
            RoleId = long.Parse(_auth.CurrentAccountRole());
            AccountInfo = _account.GetValueForEdit(_auth.CurrentAccountId());
            Account = _repository.GetProfileItems(_auth.CurrentAccountId());
            Address = _repository.GetValueForEditAddress(_auth.CurrentAccountId());
        }
        public RedirectToPageResult OnPostAddress(AddressQueryViewModel commend)
        {
            _repository.EditAddress(commend);
            return RedirectToPage();
        }
        public RedirectToPageResult OnPostInfo(EditAccount commend)
        {
            _account.Edit(commend);
            return RedirectToPage();
        }
    }
}
