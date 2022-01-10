using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using AM.Application.Contract.Role;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly IAccountApplication _repository;
        public  List<SelectListItem> Roles;
        private readonly IRoleApplication _roles;
        public CreateModel(IAccountApplication repository, IRoleApplication roles)
        {
            _repository = repository;
            _roles = roles;
         
        }
        public void OnGet()
        {
            Roles = _roles.List().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            
        }
        public RedirectToPageResult OnPost(CreateAccount commend)
        {
            
            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
