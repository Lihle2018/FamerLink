namespace Domain.Interfaces.Services
{
    public interface INotificationService
    {
        void SendEmail(string recipient, string subject, string message);
        void SendSms(string phoneNumber, string message);
        void SendPushNotification(string userId, string message);
    }
}
