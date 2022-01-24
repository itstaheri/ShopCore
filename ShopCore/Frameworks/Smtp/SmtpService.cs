using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Smtp
{
    public class SmtpService : ISmtpService
    {

        public void Send(EmailViewModel commend)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("mobilsmtpshopp@gmail.com", "@Zxcvbnm123");

            // Mail Message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("mobilsmtpshopp@gmail.com");
            message.To.Add(commend.Emailreceiver);
            message.Subject = commend.Subject;
            message.IsBodyHtml = true;
            message.Body = commend.UserEmail + " : " + commend.Text;

            // Send Mail
            smtpClient.Send(message);
        }
    }
}
