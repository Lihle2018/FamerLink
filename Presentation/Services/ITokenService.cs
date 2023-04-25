namespace Presentation.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IdentityUser user,int expire=15); 
    }
}
