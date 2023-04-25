using Microsoft.AspNetCore.Identity;
using Presentation.DTOs;

namespace Presentation.Services
{
    public interface IAuthenticationMediator
    {
        Task<AuthenticationResponseDto> Authenticate(LoginDto loginDto);
        Task<AuthenticationResponseDto> Register(RegisterDto registerDto);
        Task<IdentityUser> AuthenticateWithGoogle(string idToken);
        Task<IdentityUser> AuthenticateWithFacebook(string accessToken);
    }
}
