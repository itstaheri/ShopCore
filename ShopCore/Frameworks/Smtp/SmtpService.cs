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
        public void ForgotPassword(string Email,string Password)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("mobilsmtpshopp@gmail.com", "@Zxcvbnm123");

            MailMessage message = new MailMessage();
            message.From = new MailAddress("mobilsmtpshopp@gmail.com");
            message.To.Add(Email);
            message.Subject = "فراموشی رمزعبور";
            message.IsBodyHtml = true;
            message.Body = "رمز عبور موقت شما : " + Password;

            smtpClient.Send(message);
        }

        public void Send(EmailViewModel commend)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("mobilsmtpshopp@gmail.com", "@Zxcvbnm123");

            MailMessage message = new MailMessage();
            message.From = new MailAddress("mobilsmtpshopp@gmail.com");
            message.To.Add(commend.Emailreceiver);
            message.Subject = commend.Subject;
            message.IsBodyHtml = true;
            message.Body = commend.UserEmail + " : " + commend.Text;

            smtpClient.Send(message);
        }
    }
}
