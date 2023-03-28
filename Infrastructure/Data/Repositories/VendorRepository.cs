using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        public VendorRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Vendor> GetByLocation(Location location)
        {
            return _context.Vendors.Where(v => v.Location.Id == location.Id).ToList();
        }

        public IEnumerable<Vendor> GetByProduct(Product product)
        {
            return _context.Vendors.Where(v => v.Products.Any(p => p.Id == product.Id)).ToList();
        }
    }
}
