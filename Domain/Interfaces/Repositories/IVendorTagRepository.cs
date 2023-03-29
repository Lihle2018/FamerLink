namespace Domain.Interfaces.Repositories
{
    public interface IVendorTagRepository : IRepository<VendorTag>
    {
        List<VendorTag> GetAllByVendorId(int vendorId);
    }
}
