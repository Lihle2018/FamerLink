

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        IVendorRepository Vendors { get; }
        ILocationRepository Locations { get; }
        IPaymentRepository Payments { get; }
        ITransactionRepository Transactions { get; }
        IPromotionRepository Promotions { get; }
        ICartItemRepository CartItems { get; }
        IReviewRepository Reviews { get; }
        ITagRepository Tags { get; }

        void Save();
        Task SaveAsync();
    }
}
