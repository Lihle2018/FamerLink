using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Cms;
using Presentation.DTOs;
using Presentation.Services;
using System.CodeDom.Compiler;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationMediator _mediator;
        private readonly IEmailService _emailService;

        public AuthenticationController(IEmailService emailService, IAuthenticationMediator mediator)
        {
            _emailService = emailService;
            _mediator= mediator;
            
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto model)
        {
           if(ModelState.IsValid)
            {
                var result = await _mediator.Register(model);
                if (result == null)
                {
                    return BadRequest("Something went wrong, Please try again");
                }
                else
                {
                    _emailService.SendEmail(model.Email, "Welcome", "You are one of us now");
                    return Ok();
                }
            }
            return BadRequest(string.Join("\n", ModelState.Select(x => x.Value.Errors)));
        }


        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromBody] LoginDto User)
        {
            if(ModelState.IsValid)
            {
                var user =await _mediator.Authenticate(User);
                if(user!=null)
                {
                   
                    return Ok(user.Token);
                }
                return NotFound("User not found");
            }
            return Unauthorized("Password or username is invalid");
        }
    }
}
