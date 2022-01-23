using Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingManagement
{
    public class SettingRepository : ISettingRepository
    {
        private readonly SettingContext _context;
        private readonly IFileUploader _Uploader;

        public SettingRepository(SettingContext context, IFileUploader Uploader)
        {
            _context = context;
            _Uploader = Uploader;
        }

        public void Edit(settingViewModel commend)
        {
            var setting = _context.setting.FirstOrDefault();
            if (setting == null) Record(commend);
            else
            {
                var logo = _Uploader.Upload(commend.Logo, "LogoImages", "Logo");

                setting.Edit(commend.ContectNumber, commend.ContectEmail, commend.HeaderRight, commend.HeaderLeft, logo, commend.BannerOne, commend.BannerTwo, commend.ContectUs, commend.ContectUsAdd, commend.SmtpEmail);
                _context.SaveChanges();
            }
            
        }

        public settingViewModel GetValue()
        {
            return _context.setting.Select(x => new settingViewModel
            {
                ContectEmail = x.ContectEmail,
                BannerOne = x.BannerOne,
                BannerTwo = x.BannerTwo,
                ContectNumber = x.ContectNumber,
                ContectUs = x.ContectUs,
                ContectUsAdd = x.ContectUsAdd,
                HeaderLeft = x.HeaderLeft,
                HeaderRight = x.HeaderRight,
                LogoName = x.Logo,
                SmtpEmail = x.SmtpEmail
            }).FirstOrDefault();

        }

        public void Record(settingViewModel commend)
        {
            string logo = "";
            if (commend.Logo != null)
            {
                logo = _Uploader.Upload(commend.Logo, "LogoImages", commend.Logo.FileName);

            }
            var setting = new SettingModel(commend.ContectNumber, commend.ContectEmail, commend.HeaderRight, commend.HeaderLeft, logo, commend.BannerOne, commend.BannerTwo, commend.ContectUs, commend.ContectUsAdd, commend.SmtpEmail);
            _context.setting.Add(setting);
            _context.SaveChanges();
        }
    }
}
