using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Admin.Pages.Shop.Accounts
{
    public class EditModel : PageModel
    {
        private readonly IAccountApplication _repository;
        public List<SelectListItem> Roles { get; set; }
        [BindProperty] public EditAccount Account { get; set; }

        public EditModel(IAccountApplication repository)
        {
            _repository = repository;
        }
        public void OnGet(long id)
        {
            Account = _repository.GetValueForEdit(id);
        }
        public RedirectToPageResult OnPost(EditAccount commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");
        }
    }
}
