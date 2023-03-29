namespace Infrastructure.Data.Repositories
{
    public class PaymentRepository : Repository<Payment>,IPaymentRepository
    {
        public PaymentRepository(FarmLinkDbContext context) : base(context)
        {
        }
        public Payment GetByOrderId(int orderId)
        {
          return  _context.Payments.FirstOrDefault(o=>o.OrderId == orderId);
        }
    }
}
