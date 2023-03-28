using Domain.Entities;
namespace Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetByProduct(Product product);
    }
}
