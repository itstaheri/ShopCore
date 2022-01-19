using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks
{
    public class PaymentResultMassage
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }

        public PaymentResultMassage Succeeded(string message,string code)
        {
            IsSuccessful = true;
            Message = message;
            Code = code;
            return this;
        }
        public PaymentResultMassage Faild(string message)
        {
            IsSuccessful = false;
            Message = message;
            return this;
        }
    }
}
