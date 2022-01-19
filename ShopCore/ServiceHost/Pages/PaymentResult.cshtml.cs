using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frameworks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class PaymentResultModel : PageModel
    {
        public PaymentResultMassage Payment;
        public void OnGet(PaymentResultMassage payment)
        {
            Payment = payment;
        }
    }
}
