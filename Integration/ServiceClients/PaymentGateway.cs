namespace Integration.ServiceClients
{
    public class PaymentGateway : IPaymentGateway
    {
        public bool ProcessPayment(Order order, PaymentMethod paymentMethod, Payment paymentDetails)
        {
            throw new NotImplementedException();
        }
    }
}
