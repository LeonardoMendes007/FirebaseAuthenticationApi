using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirebaseAuthenticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet("NoAutentication")]
        public IActionResult NoAuthentication()
        {
            return Ok("Sem autenticacao");
        }

        [HttpGet("WithAutentication")]
        [Authorize]
        public IActionResult WithAuthentication()
        {
            return Ok("Com autenticacao");
        }
    }
}
