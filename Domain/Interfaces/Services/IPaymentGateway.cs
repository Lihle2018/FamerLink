namespace Domain.Interfaces.Services
{
    public interface IPaymentGateway
    {
        bool ProcessPayment(Order order, PaymentMethod paymentMethod, Payment paymentDetails);
    }
}
