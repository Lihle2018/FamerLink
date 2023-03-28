using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        IEnumerable<Transaction> GetByCustomer(Customer customer);
        IEnumerable<Transaction> GetByVendor(Vendor vendor);
    }
}
