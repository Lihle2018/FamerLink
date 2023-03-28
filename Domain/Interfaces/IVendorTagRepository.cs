using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IVendorTagRepository : IRepository<VendorTag>
    {
        Task<List<VendorTag>> GetAllByVendorIdAsync(int vendorId);
    }
}
