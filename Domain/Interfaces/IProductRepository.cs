using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByProductVendor(Vendor vendor);
    }
}
