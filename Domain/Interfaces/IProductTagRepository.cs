using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IProductTagRepository:IRepository<ProductTag>
    {
        List<ProductTag> GetAllByProductId(int ProductId);
    }
}
