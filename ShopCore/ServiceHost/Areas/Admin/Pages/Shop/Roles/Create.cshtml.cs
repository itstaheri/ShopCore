using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Shop.Roles
{
    public class CreateModel : PageModel
    {
        private readonly IRoleApplication _repository;

        public CreateModel(IRoleApplication repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {

        }
        public RedirectToPageResult OnPost(CreateRole commend)
        {
            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
