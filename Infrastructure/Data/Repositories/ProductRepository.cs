using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetByProductVendor(Vendor vendor)
        {
            return _context.Products.Where(p => p.VendorId == vendor.Id);
        }
    }

}
