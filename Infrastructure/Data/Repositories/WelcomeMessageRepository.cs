namespace Infrastructure.Data.Repositories
{
    public class WelcomeMessageRepository : Repository<WelcomeMessage>, IWelcomeMessageRepository
    {
        public WelcomeMessageRepository(FarmLinkDbContext context) : base(context)
        {
        }
    }
}
