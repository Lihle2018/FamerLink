using Domain.Interfaces.Services;
using System.Net.Mail;
namespace Domain.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient _smtpClient;

//var smtpClient = new SmtpClient("smtp.gmail.com", 587);
//smtpClient.UseDefaultCredentials = false;
//smtpClient.Credentials = new NetworkCredential("your-email-address@gmail.com", "your-email-password");
//smtpClient.EnableSsl = true;

        public EmailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void SendEmail(string toAddress, string subject, string body)
        {
            var message = new MailMessage();
            message.To.Add(toAddress);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            _smtpClient.Send(message);
        }
    }
}
