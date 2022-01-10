using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Shop.Roles
{
    public class IndexModel : PageModel
    {
        private readonly IRoleApplication _repository;
        public List<RoleViewModel> Roles;
        public IndexModel(IRoleApplication repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Roles = _repository.List();
        }
    }
}
