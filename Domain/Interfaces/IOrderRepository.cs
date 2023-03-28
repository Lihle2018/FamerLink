using Domain.Entities;


namespace Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetOrdersByCustomer(Customer customer);
        IEnumerable<Order> GetOrdersByVendor(Vendor vendor);
        IEnumerable<Order> GetByStatus(OrderStatus status);
    }
}
