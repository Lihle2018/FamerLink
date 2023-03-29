namespace Domain.Interfaces.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
        List<ProductTag> GetAllByProductId(int ProductId);
    }
}
