using Domain.Interfaces.Services;
using System.Net;
using System.Net.Mail;
namespace Domain.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {
           
        }

        public void SendEmail(string toAddress, string subject, string body)
        {
            // Create a new MailMessage object
            MailMessage message = new MailMessage("student24donotreply@gmail.com", toAddress, subject, body) { Priority = MailPriority.High, ReplyTo = new MailAddress("student24donotreply@gmail.com") };
            // Set the server and credentials for sending the email
            var password = "oxdzqdneoaxpqzsc";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("student24donotreply@gmail.com", password)
            };
            smtp.SendAsync(message, null);
        }
    }
}
