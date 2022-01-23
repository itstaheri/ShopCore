using System;
using System.ComponentModel.DataAnnotations;

namespace SettingManagement
{
    public class SettingModel
    {
        public SettingModel(string contectNumber, string contectEmail, string headerRight, string headerLeft, string logo, string bannerOne, string bannerTwo, string contectUs, string contectUsAdd, string smtpEmail)
        {
            ContectNumber = contectNumber;
            ContectEmail = contectEmail;
            HeaderRight = headerRight;
            HeaderLeft = headerLeft;
            Logo = logo;
            BannerOne = bannerOne;
            BannerTwo = bannerTwo;
            ContectUs = contectUs;
            ContectUsAdd = contectUsAdd;
            SmtpEmail = smtpEmail;
        }
        public void Edit(string contectNumber, string contectEmail, string headerRight, string headerLeft, string logo, string bannerOne, string bannerTwo, string contectUs, string contectUsAdd, string smtpEmail)
        {
            ContectNumber = contectNumber;
            ContectEmail = contectEmail;
            HeaderRight = headerRight;
            HeaderLeft = headerLeft;
            if (!string.IsNullOrWhiteSpace(logo))
            {
                Logo = logo;
            }
            BannerOne = bannerOne;
            BannerTwo = bannerTwo;
            ContectUs = contectUs;
            ContectUsAdd = contectUsAdd;
            SmtpEmail = smtpEmail;
        }
        [Key]
        public long Id { get; private set; }
        public string ContectNumber { get; private set; }
        public string ContectEmail { get; private set; }
        public string HeaderRight { get; private set; }
        public string HeaderLeft { get; private set; }
        public string Logo { get; private set; }
        public string BannerOne { get; private set; }
        public string BannerTwo { get; private set; }
        public string ContectUs { get; private set; }
        public string ContectUsAdd { get; private set; }
        public string SmtpEmail { get; private set; }

    }
}
