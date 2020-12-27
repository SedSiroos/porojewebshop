using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Poroject.Core.Convertors
{
    public class SendEmail
    {
        public static void Send(string to,string subject,string body)
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("siroos.ghal@gmail.com", "پروژه دات کام");
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("siroos.ghal@gmail.com", "c||c+1!s");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
