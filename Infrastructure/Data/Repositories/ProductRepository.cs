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
