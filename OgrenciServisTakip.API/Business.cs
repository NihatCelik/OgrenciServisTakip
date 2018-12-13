using System.Net;
using System.Net.Mail;

namespace OgrenciServisTakip.API
{
    public class Business
    {
        public static void MailSender(string body, string to)
        {
            var fromAddress = new MailAddress("infoeticaretdersi@gmail.com");
            var toAddress = new MailAddress(to);
            string subject = "Öğrenci Servis Takip | Şifre";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "eticaretDersi.1")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}