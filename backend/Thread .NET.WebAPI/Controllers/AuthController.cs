using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Generates user token for authorization
        /// </summary>
        /// /// <remarks>
        /// Sample request with existing user:
        ///
        ///     POST /api/auth/login
        ///     {
        ///        "email": "test@gmail.com",
        ///        "password": "passw0rd"
        ///     }
        ///
        /// </remarks>
        [HttpPost("login")]
        public async Task<ActionResult<AuthUserDTO>> Login(UserLoginDTO dto)
        {
            return Ok(await _authService.Authorize(dto));
        }
    }
}