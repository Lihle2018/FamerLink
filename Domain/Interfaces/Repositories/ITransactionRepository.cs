namespace Domain.Interfaces.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        IEnumerable<Transaction> GetByCustomer(Customer customer);
        IEnumerable<Transaction> GetByVendor(Vendor vendor);
    }
}
