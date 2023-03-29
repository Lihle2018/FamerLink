namespace Infrastructure.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Order> GetByStatus(OrderStatus status)
        {
            return _context.Orders.Where(o => o.Status == status).ToList();
        }

        public IEnumerable<Order> GetOrdersByCustomer(Customer customer)
        {
            return _context.Orders.Where(o => o.Customer.Id == customer.Id).ToList();
        }
        public IEnumerable<Order> GetOrdersByVendor(Vendor vendor)
        {
            return _context.Orders.Where(o => o.VendorId == vendor.Id).ToList();
        }
    }
}
