using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Sms
{
    public class SmsService :  ISmsService
    {
        public void Sendsms(string number, string Messege)
        {
            var lines = new SmsLine().GetSmsLines(GetToken());
            if (lines == null) return;

            var line = lines.SMSLines.Last().LineNumber.ToString();
            var messageSendObject = new MessageSendObject()
            {
                Messages = new List<string> { Messege }.ToArray(),
                MobileNumbers = new List<string> {number }.ToArray(),
                LineNumber = line,
                SendDateTime = DateTime.Now,
                CanContinueInCaseOfError = true
            };

            MessageSendResponseObject messageSendResponseObject = new MessageSend().Send(GetToken(), messageSendObject);

            if (messageSendResponseObject.IsSuccessful) return;

            line = lines.SMSLines.First().LineNumber.ToString();
            messageSendObject.LineNumber = line;
            new MessageSend().Send(GetToken(), messageSendObject);

        }
        public string GetToken()
        {
            SmsIrRestful.Token tk = new SmsIrRestful.Token();
            string result = tk.GetToken("9f836f01b0809cdbab6489c", "abcd");
            return result;
        }
    }
}
