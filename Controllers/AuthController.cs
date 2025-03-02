using Microsoft.AspNetCore.Mvc;
using JobMatchingAPI.Services;

namespace JobMatchingAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "password") // Dummy check
            {
                var token = _tokenService.GenerateToken(request.Username);
                return Ok(new { token });
            }
            return Unauthorized();
        }
    }

    public class LoginRequest
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
