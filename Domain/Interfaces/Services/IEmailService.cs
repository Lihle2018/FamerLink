namespace Domain.Interfaces.Services
{
    public interface IEmailService
    {
        void SendEmail(string toAddress, string subject, string body);
    }
}
