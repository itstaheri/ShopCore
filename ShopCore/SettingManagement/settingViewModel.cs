using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingManagement
{
    public class settingViewModel
    {
        public string ContectNumber { get;  set; }
        public string ContectEmail { get;  set; }
        public string HeaderRight { get;  set; }
        public string HeaderLeft { get;  set; }
        public IFormFile Logo { get;  set; }
        public string LogoName { get;  set; }
        public string BannerOne { get;  set; }
        public string BannerTwo { get;  set; }
        public string ContectUs { get;  set; }
        public string ContectUsAdd { get;  set; }
        public string SmtpEmail { get;  set; }
    }
}
