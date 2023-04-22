using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            

            //modelBuilder.Entity<Location>().OwnsOne(x => x.Address, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(address => address.Street);
            //    NavigationBuilder.Property(address => address.City);
            //    NavigationBuilder.Property(address => address.State);
            //    NavigationBuilder.Property(address => address.ZipCode);
            //});
            //modelBuilder.Entity<Location>().OwnsOne(x => x.GeoLocation, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(geolocation => geolocation.Latitude);
            //    NavigationBuilder.Property(geolocation => geolocation.Longitude);
            //});
            //modelBuilder.Entity<Vendor>().OwnsOne(x => x.ContactInfo, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(address => address.Email);
            //    NavigationBuilder.Property(address => address.Phone);
            //});
            //modelBuilder.Entity<Vendor>().OwnsOne(x => x.MinimumOrderAmount, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(money => money.Amount);
            //    NavigationBuilder.OwnsOne(money => money.Currency,NavigationBuilder=>
            //    {
            //        NavigationBuilder.Property(currency => currency.Code);
            //    });
            //});
            //modelBuilder.Entity<Order>().OwnsOne(x => x.DeliveryFee, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(money => money.Amount);
            //    NavigationBuilder.OwnsOne(money => money.Currency, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(currency => currency.Code);
            //    });
            //});
            //modelBuilder.Entity<Order>().OwnsOne(x => x.RefundAmount, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(money => money.Amount);
            //    NavigationBuilder.OwnsOne(money => money.Currency, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(currency => currency.Code);
            //    });
            //});
            //modelBuilder.Entity<Order>().OwnsOne(x => x.TaxAmount, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(money => money.Amount);
            //    NavigationBuilder.OwnsOne(money => money.Currency, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(currency => currency.Code);
            //    });
            //});
            //modelBuilder.Entity<Order>().OwnsOne(x => x.TotalAmount, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(money => money.Amount);
            //    NavigationBuilder.OwnsOne(money => money.Currency, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(currency => currency.Code);
            //    });
            //});
            //modelBuilder.Entity<Order>().OwnsOne(x => x.PaymentMethod, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(pm => pm.Name);
            //    NavigationBuilder.OwnsOne(pm => pm.CreditCard, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(creditCard => creditCard.CardholderName);
            //        NavigationBuilder.Property(creditCard => creditCard.CardNumber);
            //        NavigationBuilder.Property(creditCard => creditCard.ExpirationMonth);
            //        NavigationBuilder.Property(creditCard => creditCard.ExpirationYear);
            //        NavigationBuilder.Property(creditCard => creditCard.CVV);
            //    });
            //    NavigationBuilder.OwnsOne(pm => pm.BankAccount, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(bankAccount => bankAccount.AccountNumber);
            //        NavigationBuilder.Property(bankAccount => bankAccount.RoutingNumber);
            //    });
                
            //});
            //modelBuilder.Entity<Transaction>().OwnsOne(x => x.PaymentMethod, NavigationBuilder =>
            //{
            //    NavigationBuilder.Property(pm => pm.Name);
            //    NavigationBuilder.OwnsOne(pm => pm.CreditCard, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(creditCard => creditCard.CardholderName);
            //        NavigationBuilder.Property(creditCard => creditCard.CardNumber);
            //        NavigationBuilder.Property(creditCard => creditCard.ExpirationMonth);
            //        NavigationBuilder.Property(creditCard => creditCard.ExpirationYear);
            //        NavigationBuilder.Property(creditCard => creditCard.CVV);
            //    });
            //    NavigationBuilder.OwnsOne(pm => pm.BankAccount, NavigationBuilder =>
            //    {
            //        NavigationBuilder.Property(bankAccount => bankAccount.AccountNumber);
            //        NavigationBuilder.Property(bankAccount => bankAccount.RoutingNumber);
            //    });

            //});
        }
    }
}
