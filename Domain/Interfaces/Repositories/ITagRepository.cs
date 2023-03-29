namespace Domain.Interfaces.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
        IEnumerable<Tag> GetByVendor(Vendor vendor);
    }
}
