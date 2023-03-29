
namespace Infrastructure.Data.Repositories
{
    public class VendorTagRepository : Repository<VendorTag>, IVendorTagRepository
    {
        public VendorTagRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public List<VendorTag> GetAllByVendorId(int vendorId)
        {
            return _context.VendorTags.Where(v => v.VendorId == vendorId).ToList();
        }
    }
}
