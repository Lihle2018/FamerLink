using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        IEnumerable<Vendor> GetByLocation(Location location);
        IEnumerable<Vendor> GetByProduct(Product product);
    }
}
