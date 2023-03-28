using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        IEnumerable<Review> GetByProduct(Product product);
        IEnumerable<Review> GetByCustomer(Customer customer);
    }
}
