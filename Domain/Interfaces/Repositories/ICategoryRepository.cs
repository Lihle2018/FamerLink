namespace Domain.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetByProduct(Product product);
    }
}
