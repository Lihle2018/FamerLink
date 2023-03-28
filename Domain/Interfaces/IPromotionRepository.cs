using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IPromotionRepository: IRepository<Promotion>
    {
        IEnumerable<Promotion> GetByProduct(Product customer);
        IEnumerable<Promotion> GetByVendor(Vendor vendor);
    }
}
