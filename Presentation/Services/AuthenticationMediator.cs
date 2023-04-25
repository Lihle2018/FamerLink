using Microsoft.AspNetCore.Identity;
using Presentation.DTOs;

namespace Presentation.Services
{
    public class AuthenticationMediator : IAuthenticationMediator
    {
        //private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly IGoogleAuthService _googleAuthService;
        //private readonly IFacebookAuthService _facebookAuthService;


        public AuthenticationMediator(ITokenService tokenService,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _tokenService = tokenService;
            _userManager = userManager;
            _signInManager = signInManager;
            //_googleAuthService = googleAuthService;
            //_facebookAuthService = facebookAuthService;
        }

        public async Task<AuthenticationResponseDto> Authenticate(LoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                return null;
            }
            // Authenticate user using SignInManager
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
            if (result.Succeeded)
            {
                var token = _tokenService.GenerateAccessToken(user);
                var response = new AuthenticationResponseDto()
                {
                    Token = token,
                    RefreshToken= Guid.NewGuid().ToString(),
                    Expiration= DateTime.UtcNow.AddMinutes(15)
                };
            }
            return null;
        }

        public async Task<AuthenticationResponseDto> Register(RegisterDto request)
        {
            var user = new IdentityUser
            {
                UserName = request.Username,
                Email = request.Email,
                // Set other properties of the user as needed
            };

            // Register the user with Identity
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                // User registration successful, generate access token and refresh token
                var accessToken = _tokenService.GenerateAccessToken(user);
                var refreshToken = _tokenService.GenerateAccessToken(user, 43200);

                // Store the refresh token in the database
               // await _userRepository.AddRefreshTokenAsync(user.Id, refreshToken);

                // Create and return the authentication response DTO
                var response = new AuthenticationResponseDto
                {
                    Token = accessToken,
                    RefreshToken = refreshToken,
                    Expiration = DateTime.UtcNow.AddMinutes(43200)
                };
                return response;
            }
            else
            {
                // User registration failed, return appropriate error response
                var errors = result.Errors.Select(e => e.Description).ToList();
                throw new ApplicationException($"Failed to register user: {string.Join(", ", errors)}");
            }
        }


        public async Task<IdentityUser> AuthenticateWithGoogle(string idToken)
        {
            // Handle Google sign-in logic
            throw new NotImplementedException();
        }

        public async Task<IdentityUser> AuthenticateWithFacebook(string accessToken)
        {
            // Handle Facebook sign-in logic
            throw new NotImplementedException();
        }
    }

}
