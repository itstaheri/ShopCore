using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application.Contract.Role;
using Frameworks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Admin.Pages.Shop.Roles
{
    public class EditModel : PageModel
    {
        private readonly IRoleApplication _repository;
        public EditRole Roles;
        private readonly IEnumerable<IPermisionExposer> _exposers;
        public List<SelectListItem> permissions = new List<SelectListItem>();
        public EditModel(IRoleApplication repository, IEnumerable<IPermisionExposer> exposers)
        {
            _repository = repository;
            _exposers = exposers;
        }

        public void OnGet(long Id)
        {
            Roles = _repository.ValueForEdit(Id);

            foreach (var ex in _exposers)
            {
                var exposedPermissions = ex.Expose();
                foreach (var (key, value) in exposedPermissions)
                {
                    var group = new SelectListGroup { Name = key };
                    foreach (var permission in value)
                    {
                        var item = new SelectListItem(permission.Name, permission.Code.ToString())
                        {
                            Group = group
                        };

                        if (Roles.Mappedpermisions.Any(x => x.Code == permission.Code))
                            item.Selected = true;

                        permissions.Add(item);
                    }
                }
            }
            //var permisions = new List<PermisionDto>();

            //foreach (var ex in _exposers)
            //{
            //    var exposterPermisions = ex.Expose();
            //    foreach (var (key, value) in exposterPermisions)
            //    {
            //        permissions.Add(value);
            //        var group = new SelectListGroup
            //        {
            //            Name = key
            //        };
            //        foreach (var pm in value)
            //        {
            //            var item = new SelectListItem(pm.Name, pm.Code.ToString())
            //            {
            //                Group = group
            //            };
            //            if (Roles.Mappedpermisions.Any(x=>x.Code == pm.Code))
            //            {
            //                item.Selected = true;
            //            }
            //            permissions.Add(item);
            //        }

            //    }
            //}
        }
        public RedirectToPageResult OnPost(EditRole commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");
        }
    }
}
