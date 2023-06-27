using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread.NET.BLL.Services;
using Thread.NET.Common.DTO.Auth;
using Thread.NET.Extensions;

namespace Thread.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly AuthService _authService;

        public TokenController(AuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Refreshes user token and creates new access token
        /// </summary>
        [HttpPost("refresh")]
        [AllowAnonymous]
        public async Task<ActionResult<AccessTokenDTO>> Refresh([FromBody] RefreshTokenDTO dto)
        {
            return Ok(await _authService.RefreshToken(dto));
        }

        /// <summary>
        /// Revokes refresh tokens
        /// </summary>
        [HttpPost("revoke")]
        public async Task<IActionResult> RevokeRefreshToken([FromBody] RevokeRefreshTokenDTO dto)
        {
            await _authService.RevokeRefreshToken(dto.RefreshToken);
            return Ok();
        }
    }
}