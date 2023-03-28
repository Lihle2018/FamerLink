using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;

namespace Infrastructure.Data.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Tag> GetByVendor(Vendor vendor)
        {
            return _context.VendorTags
             .Where(vt => vt.VendorId == vendor.Id)
             .Select(vt => vt.Tag)
             .Distinct()
             .ToList();
        }
    }
}
