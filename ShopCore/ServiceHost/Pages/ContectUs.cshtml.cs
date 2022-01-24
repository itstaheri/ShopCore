using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frameworks.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ContectUsModel : PageModel
    {
        private readonly ISmtpService _service;

        public ContectUsModel(ISmtpService service)
        {
            _service = service;
        }

        public void OnGet(EmailViewModel commend)
        {

        }
        public RedirectToPageResult OnPost(EmailViewModel commend)
        {

            _service.Send(commend);
            return RedirectToPage();
            ViewData["Result"] = "پیغام شما با موفقیت ارسال شد. منتظر پاسخ از طرف کارشناسان ما باشید.";
        }
    }
}
