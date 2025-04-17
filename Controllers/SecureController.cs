using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestedeApi2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            var username = User.Identity?.Name ?? "desconhecido";
            return Ok($"Este é um dado protegido. Olá, {username}!");
        }
    }
}
