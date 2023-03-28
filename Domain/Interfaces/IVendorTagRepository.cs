using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IVendorTagRepository : IRepository<VendorTag>
    {
       List<VendorTag> GetAllByVendorId(int vendorId);
    }
}
