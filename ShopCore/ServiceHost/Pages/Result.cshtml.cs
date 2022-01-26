using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ResultModel : PageModel
    {
        public string message;
        public void OnGet(string Message)
        {
            message = Message;
        }
    }
}
