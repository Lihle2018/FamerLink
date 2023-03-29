namespace Domain.Interfaces.Repositories
{
    public interface IPromotionRepository : IRepository<Promotion>
    {
        IEnumerable<Promotion> GetByProduct(Product customer);
        IEnumerable<Promotion> GetByVendor(Vendor vendor);
    }
}
