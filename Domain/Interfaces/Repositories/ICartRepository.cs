namespace Domain.Interfaces.Repositories
{
    public interface ICartItemRepository : IRepository<OrderItem>
    {
        IEnumerable<OrderItem> GetByCustomer(Customer customer);
    }
}
