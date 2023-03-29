namespace Domain.Interfaces.Repositories
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Payment GetByOrderId(int orderId);
    }

}
