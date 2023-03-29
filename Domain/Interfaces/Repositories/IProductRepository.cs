namespace Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByProductVendor(Vendor vendor);
    }
}
