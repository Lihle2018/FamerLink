namespace Infrastructure.Data.Repositories
{
    public class CartItemRepository : Repository<OrderItem>, ICartItemRepository
    {
        public CartItemRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<OrderItem> GetByCustomer(Customer customer)
        {
            return _context.OrderItems.Where(oi => oi.CustomerId== customer.Id);
        }
    }
}
