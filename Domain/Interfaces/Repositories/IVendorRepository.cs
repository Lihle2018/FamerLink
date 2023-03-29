namespace Domain.Interfaces.Repositories
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        IEnumerable<Vendor> GetByLocation(Location location);
        IEnumerable<Vendor> GetByProduct(Product product);
    }
}
