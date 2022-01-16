 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using AM.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly IAccountApplication _repository;
        private readonly IRoleApplication _role;
        public List<AccountViewModel> Accounts;
        public List<SelectListItem> RoleSelect;
        public RoleViewModel Role;

        public IndexModel(IAccountApplication repository, IRoleApplication role)
        {
            _repository = repository;
            _role = role;
        }

        AccountSearchModel Null;
        public void OnGet()
        {
            RoleSelect = _role.List().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            Accounts = _repository.List(Null);
            
        }
        public void OnPost(AccountSearchModel searchModel)
        {
            Accounts = _repository.List(searchModel);
           
        }
        public RedirectToPageResult OnPostDeleted(long Id)
        {
            _repository.Removed(Id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnPostActive(long Id)
        {
            _repository.Active(Id);
            return RedirectToPage("./Index");
        }
    }
}
