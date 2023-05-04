using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace FarmLink.Infrastructure.Data
{
    public class FarmLinkDbContext : IdentityDbContext<IdentityUser>
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
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductTag>().HasKey(x=>new{x.ProductId,x.TagId});
            modelBuilder.Entity<UserRole>().HasKey(x => new {x.UserId,x.RoleId});
            #region Seed Welcome messages
            modelBuilder.Entity<WelcomeMessage>().HasData(
        new WelcomeMessage { MessageId = 1, Subject = "Welcome aboard!", Content = "We're thrilled to have you as part of our team." },
        new WelcomeMessage { MessageId = 2, Subject = "Thanks for signing up!", Content = "We appreciate you choosing our service." },
        new WelcomeMessage { MessageId = 3, Subject = "You're officially part of the family!", Content = "We can't wait to get to know you better." },
        new WelcomeMessage { MessageId = 4, Subject = "Welcome to the club!", Content = "We're happy to have you as a member." },
        new WelcomeMessage { MessageId = 5, Subject = "Welcome to our platform!", Content = "We're thrilled to have you here. Let us know if you need anything." },
        new WelcomeMessage { MessageId = 6, Subject = "Thanks for joining us!", Content = "We're excited to see what you'll do with our platform." },
        new WelcomeMessage { MessageId = 7, Subject = "Welcome aboard!", Content = "You're now part of our community. Let's get started!" },
        new WelcomeMessage { MessageId = 8, Subject = "It's great to have you!", Content = "We hope you'll enjoy our platform and find it useful." },
        new WelcomeMessage { MessageId = 9, Subject = "Welcome to the team!", Content = "We're looking forward to working with you." },
        new WelcomeMessage { MessageId=10, Subject = "Thanks for signing up!", Content = "We appreciate your interest in our platform." },
        new WelcomeMessage { MessageId = 11, Subject = "Welcome to our family!", Content = "We'll do our best to make you feel at home here." },
        new WelcomeMessage { MessageId = 12, Subject = "You're in!", Content = "Congratulations on joining our platform. Let's make great things happen!" },
        new WelcomeMessage { MessageId = 13, Subject = "Welcome to the party!", Content = "We're so happy you're here. Let's have some fun!" },
        new WelcomeMessage { MessageId = 14, Subject = "Let's get started!", Content = "Thanks for choosing our platform. We can't wait to see what you'll do with it." },
        new WelcomeMessage { MessageId = 15, Subject = "Welcome to the club!", Content = "You're now part of a vibrant community. Enjoy your stay!" },
        new WelcomeMessage { MessageId = 16, Subject = "It's nice to meet you!", Content = "We're excited to have you as part of our platform." },
        new WelcomeMessage { MessageId = 17, Subject = "Thanks for joining our cause!", Content = "We're making a difference together." },
        new WelcomeMessage { MessageId = 18, Subject = "Welcome to our world!", Content = "We hope you'll find our platform interesting and useful." },
        new WelcomeMessage { MessageId = 19, Subject = "We're better together!", Content = "Thanks for joining our platform. Let's collaborate and create something amazing!" },
        new WelcomeMessage { MessageId = 20, Subject = "You're one of us now!", Content = "We're happy to welcome you to our platform." },
        new WelcomeMessage { MessageId = 21, Subject = "Welcome to the future!", Content = "We're using cutting-edge technology to make a difference. Join us!" },
        new WelcomeMessage { MessageId = 22, Subject = "Thanks for being part of our community!", Content = "Together, we can achieve great things." },
        new WelcomeMessage { MessageId = 23, Subject = "You belong here!", Content = "We're a diverse and inclusive community. Welcome!" },
        new WelcomeMessage { MessageId = 24, Subject = "Welcome to the family!", Content = "We're excited to have you as part of our platform." },
        new WelcomeMessage { MessageId = 25, Subject = "Thanks for choosing us!", Content = "We're honored that you've decided to join our platform." },
        new WelcomeMessage { MessageId = 26, Subject = "Welcome to the revolution!", Content = "We're challenging the status quo and creating a better future." },
        new WelcomeMessage { MessageId = 27, Subject = "It's great to have you here!", Content = "We hope you'll enjoy our platform and find it useful." },
        new WelcomeMessage { MessageId = 28, Subject = "Thanks for becoming part of our story!", Content = "We're writing history together." },
        new WelcomeMessage { MessageId = 29, Subject = "Thank you for joining us!", Content = "We're excited to see what you'll bring to our community." },
        new WelcomeMessage { MessageId = 30, Subject = "We're so glad you're here!", Content = "Let's get started on this journey together." },
        new WelcomeMessage { MessageId = 31, Subject = "Welcome to the family!", Content = "We're here to support you every step of the way." },
        new WelcomeMessage { MessageId = 32, Subject = "Let's get started!", Content = "We can't wait to see what you'll accomplish with us." },
        new WelcomeMessage { MessageId = 33, Subject = "Welcome to the team!", Content = "We're looking forward to working with you." },
        new WelcomeMessage { MessageId = 34, Subject = "Welcome to our community!", Content = "We're so excited to have you join us." }
        );
            #endregion
            #region Commented value objects

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
            #endregion
        }
        #region SeedData method Async
        //    private async Task SeedAsync(FarmLinkDbContext dbContext)
        //    {
        //        if (await dbContext.WelcomeMessages.AnyAsync()) return;

        //        var welcomeMessages = new List<WelcomeMessage>
        //{
        //    new WelcomeMessage { Subject = "Welcome to our community!", Content = "We're so excited to have you join us."},
        //    new WelcomeMessage { Subject = "Welcome aboard!", Content = "We're thrilled to have you as part of our team."},
        //    new WelcomeMessage { Subject = "Thanks for signing up!", Content = "We appreciate you choosing our service."},
        //    new WelcomeMessage { Subject = "You're officially part of the family!", Content = "We can't wait to get to know you better."},
        //    new WelcomeMessage { Subject = "Welcome to the club!", Content = "We're happy to have you as a member."},
        //    new WelcomeMessage { Subject = "Welcome to our platform!", Content = "We're thrilled to have you here. Let us know if you need anything." },
        //    new WelcomeMessage { Subject = "Thanks for joining us!", Content = "We're excited to see what you'll do with our platform." },
        //    new WelcomeMessage { Subject = "Welcome aboard!", Content = "You're now part of our community. Let's get started!" },
        //    new WelcomeMessage { Subject = "It's great to have you!", Content = "We hope you'll enjoy our platform and find it useful." },
        //    new WelcomeMessage { Subject = "Welcome to the team!", Content = "We're looking forward to working with you." },
        //    new WelcomeMessage { Subject = "Thanks for signing up!", Content = "We appreciate your interest in our platform." },
        //    new WelcomeMessage { Subject = "Welcome to our family!", Content = "We'll do our best to make you feel at home here." },
        //    new WelcomeMessage { Subject = "You're in!", Content = "Congratulations on joining our platform. Let's make great things happen!" },
        //    new WelcomeMessage { Subject = "Welcome to the party!", Content = "We're so happy you're here. Let's have some fun!" },
        //    new WelcomeMessage { Subject = "Let's get started!", Content = "Thanks for choosing our platform. We can't wait to see what you'll do with it." },
        //    new WelcomeMessage { Subject = "Welcome to the club!", Content = "You're now part of a vibrant community. Enjoy your stay!" },
        //    new WelcomeMessage { Subject = "It's nice to meet you!", Content = "We're excited to have you as part of our platform." },
        //    new WelcomeMessage { Subject = "Thanks for joining our cause!", Content = "We're making a difference together." },
        //    new WelcomeMessage { Subject = "Welcome to our world!", Content = "We hope you'll find our platform interesting and useful." },
        //    new WelcomeMessage { Subject = "We're better together!", Content = "Thanks for joining our platform. Let's collaborate and create something amazing!" },
        //    new WelcomeMessage { Subject = "You're one of us now!", Content = "We're happy to welcome you to our platform." },
        //    new WelcomeMessage { Subject = "Welcome to the future!", Content = "We're using cutting-edge technology to make a difference. Join us!" },
        //    new WelcomeMessage { Subject = "Thanks for being part of our community!", Content = "Together, we can achieve great things." },
        //    new WelcomeMessage { Subject = "You belong here!", Content = "We're a diverse and inclusive community. Welcome!" },
        //    new WelcomeMessage { Subject = "Welcome to the family!", Content = "We're excited to have you as part of our platform." },
        //    new WelcomeMessage { Subject = "Thanks for choosing us!", Content = "We're honored that you've decided to join our platform." },
        //    new WelcomeMessage { Subject = "Welcome to the revolution!", Content = "We're challenging the status quo and creating a better future." },
        //    new WelcomeMessage { Subject = "It's great to have you here!", Content = "We hope you'll enjoy our platform and find it useful." },
        //    new WelcomeMessage { Subject = "Thanks for becoming part of our story!", Content = "We're writing history together." },
        //    new WelcomeMessage { Subject = "Thank you for joining us!", Content = "We're excited to see what you'll bring to our community."},
        //    new WelcomeMessage { Subject = "We're so glad you're here!", Content = "Let's get started on this journey together."},
        //    new WelcomeMessage { Subject = "Welcome to the family!", Content = "We're here to support you every step of the way."},
        //    new WelcomeMessage { Subject = "Let's get started!", Content = "We can't wait to see what you'll accomplish with us."},
        //    new WelcomeMessage { Subject = "Welcome to the team!", Content = "We're looking forward to working with you."}
        //        };

        //        await dbContext.WelcomeMessages.AddRangeAsync(welcomeMessages);
        //        await dbContext.SaveChangesAsync();
        //    }
        #endregion

    }
}
