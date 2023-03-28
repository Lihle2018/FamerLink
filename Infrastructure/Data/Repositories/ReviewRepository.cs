using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;


namespace Infrastructure.Data.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Review> GetByProduct(Product product)
        {
            return _context.Reviews
                .Where(r => r.Product.Id == product.Id)
                .ToList();
        }

        public IEnumerable<Review> GetByCustomer(Customer customer)
        {
            return _context.Reviews
                .Where(r => r.Customer.Id == customer.Id)
                .ToList();
        }
    }

}
