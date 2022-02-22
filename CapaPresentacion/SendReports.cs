using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace CapaPresentacion
{
   public  class SendReports
    {
        public void sendReports_Attachment(string client, string MyEmail)
        {
            
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient(client);
            mail.From = new MailAddress(MyEmail);
            mail.To.Add(client);
            mail.Subject = "Reporte de ventas";
            mail.Body = "Este es el reporte de ventas de" + DateTime.Now.ToString("M/d/yyyy");

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("report.pdf");
            mail.Attachments.Add(attachment);

            smtpClient.Port = 231;
            smtpClient.Credentials = new System.Net.NetworkCredential();
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }
    }
}
