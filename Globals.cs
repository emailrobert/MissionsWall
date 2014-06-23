using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Net.Mail;

namespace DoSomethingWeb
{
    public class Globals
    {

        public void MailMessage(string FromAddress, string ToAddress, string Subject, string Body, string smtpserver)
        {
       //     MailAddress MailToAddress = new MailAddress(ToAddress);
            MailAddress MailFromAddress = new MailAddress(FromAddress);
            MailMessage EmailMessage = new MailMessage();

            EmailMessage.From = MailFromAddress;


            string[] recipients = ToAddress.Split(',');
            foreach (string recipient in recipients)
            {
                EmailMessage.To.Add(recipient);
            }

            SmtpClient MailSender = new SmtpClient(smtpserver);
            
            EmailMessage.Subject = Subject;
            EmailMessage.Body = Body;
            
            MailSender.Send(EmailMessage);
        }

    }
}
