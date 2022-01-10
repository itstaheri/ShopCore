using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Shop.Roles
{
    public class EditModel : PageModel
    {
        private readonly IRoleApplication _repository;
        public EditRole Roles;
        public EditModel(IRoleApplication repository)
        {
            _repository = repository;
        }

        public void OnGet(long Id)
        {
            Roles = _repository.ValueForEdit(Id);
        }
        public RedirectToPageResult OnPost(EditRole commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");
        }
    }
}
