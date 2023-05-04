namespace Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FarmLinkDbContext _context;

        public UnitOfWork(FarmLinkDbContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
            Vendors = new VendorRepository(_context);
            Locations = new LocationRepository(_context);
            Payments = new PaymentRepository(_context);
            Transactions = new TransactionRepository(_context);
            CartItems = new CartItemRepository(_context);
            Reviews = new ReviewRepository(_context);
            Tags = new TagRepository(_context);
            ProductTags = new ProductTagRepository(_context);
            VendorTags = new VendorTagRepository(_context);
            WelcomeMessages=new WelcomeMessageRepository(_context);
           
        }

        public ICustomerRepository Customers { get; }
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }
        public IVendorRepository Vendors { get; }
        public ILocationRepository Locations { get; }
        public IPaymentRepository Payments { get; }
        public ITransactionRepository Transactions { get; }
        public ICartItemRepository CartItems { get; }
        public IReviewRepository Reviews { get; }
        public ITagRepository Tags { get; }
        public IProductTagRepository ProductTags { get; }
        public IVendorTagRepository VendorTags { get; }

        public IPromotionRepository Promotions { get; }
        public IWelcomeMessageRepository WelcomeMessages { get; }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
