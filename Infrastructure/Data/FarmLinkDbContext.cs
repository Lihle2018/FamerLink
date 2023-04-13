using Domain.Entities;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace FarmLink.Infrastructure.Data
{
    public class FarmLinkDbContext : DbContext
    {
        public FarmLinkDbContext(DbContextOptions<FarmLinkDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<VendorTag> VendorTags { get; set; }
        public DbSet<ProductTag> productTags { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductTag>().HasKey(x=>new{x.ProductId,x.TagId});
            modelBuilder.Entity<UserRole>().HasKey(x => new {x.UserId,x.RoleId});
           
        }
    }
}
