using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Presentation.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        public TokenService(IConfiguration config)
        {
            _config = config;
        }
        public string GenerateAccessToken(IdentityUser user,int expire=15)
        {

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
           {
                new Claim(ClaimTypes.NameIdentifier, user.UserName)
                
           };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
               _config["Jwt:Audience"],
               claims,
               expires: DateTime.Now.AddMinutes(expire),
               signingCredentials: credentials);
           
            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
