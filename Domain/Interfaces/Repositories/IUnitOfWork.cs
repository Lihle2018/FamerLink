﻿namespace Domain.Interfaces.Repositories
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
        IWelcomeMessageRepository WelcomeMessages { get; }

        void Save();
        Task SaveAsync();
    }
}
