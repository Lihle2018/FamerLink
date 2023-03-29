namespace Infrastructure.Data.Repositories
{
    public class PaymentRepository : Repository<Payment>,IPaymentRepository
    {
        public PaymentRepository(FarmLinkDbContext context) : base(context)
        {
        }
    }
}
