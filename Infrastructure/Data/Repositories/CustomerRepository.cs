using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;


namespace Infrastructure.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public Customer GetByEmail(string email)
        {

            return _context.Customers.FirstOrDefault(c => c.Email ==email);
        }

        public IEnumerable<Customer> GetCustomersByLocation(int locationId)
        {
            return _context.Customers.Where(c => c.LocationId == locationId).ToList();
        }
    }
}
