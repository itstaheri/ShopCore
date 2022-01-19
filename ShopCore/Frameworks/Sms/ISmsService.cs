using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Sms
{
    public interface ISmsService
    {
        void Sendsms(string number, string Messege);
    }
}
