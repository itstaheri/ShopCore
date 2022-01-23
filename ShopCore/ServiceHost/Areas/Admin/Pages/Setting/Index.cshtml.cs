using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SettingManagement;

namespace ServiceHost.Areas.Admin.Pages.Setting
{
    public class IndexModel : PageModel
    {
        private readonly ISettingRepository _repository;
        public settingViewModel Setting;
        public IndexModel(ISettingRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Setting = _repository.GetValue();
            if (Setting == null)
                Setting = new settingViewModel();
           

        }
        public RedirectToPageResult OnPost(settingViewModel commend)
        {
            _repository.Edit(commend);
            return RedirectToPage();

        }
    }
}
