using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Auth;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
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
            var userId = this.GetUserIdFromToken();
            await _authService.RevokeRefreshToken(dto.RefreshToken, userId);

            return Ok();
        }
    }
}