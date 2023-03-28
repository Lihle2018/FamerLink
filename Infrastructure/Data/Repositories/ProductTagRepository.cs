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
    internal class ProductTagRepository : Repository<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public List<ProductTag> GetAllByProductId(int ProductId)
        {
            return _context.productTags.Where(p=> p.ProductId == ProductId).ToList();
        }
    }
}
