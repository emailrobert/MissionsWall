using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Net.Mail;
using System.Diagnostics;
using System.Net;

namespace DoSomethingWeb
{
    public class Globals
    {

        public void MailMessage(string FromAddress, string ToAddress, string Subject, string Body, string smtpserver)
        {
            try
            {
                MailAddress MailFromAddress = new MailAddress(FromAddress);
                MailMessage EmailMessage = new MailMessage();

                EmailMessage.From = MailFromAddress;


                string[] recipients = ToAddress.Split(',');
                foreach (string recipient in recipients)
                {
                    EmailMessage.To.Add(recipient);
                }

                var client = new SmtpClient("64.26.60.229", 587)
                {
                    Credentials = new NetworkCredential("missions@visitcrossway.org", "p@ssw0rd"),
                };

                EmailMessage.Subject = Subject;
                EmailMessage.Body = Body;

                client.Send(EmailMessage);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Sending Email", ex.Message);
            }
        }

    }
}
