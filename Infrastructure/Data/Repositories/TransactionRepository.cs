
using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;

namespace Infrastructure.Data.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Transaction> GetByCustomer(Customer customer)
        {
            return _context.Transactions.Where(t=>t.CustomerId== customer.Id).ToList();
        }

        public IEnumerable<Transaction> GetByVendor(Vendor vendor)
        {
            return _context.Transactions.Where(t => t.VendorId == vendor.Id).ToList();
        }
    }
}
