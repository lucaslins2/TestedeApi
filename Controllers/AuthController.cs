using Microsoft.AspNetCore.Mvc;
using TestedeApi2.Model;
using TestedeApi2.Services;

namespace TestedeApi2.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserModel user)
        {
            // Aqui você validaria contra um banco de dados
            if (user.Username == "admin" && user.Password == "123456")
            {
                var token = _jwtService.GenerateToken(user.Username);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}
