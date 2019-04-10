using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Auth;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly AuthService _authService;

        public TokenController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("refresh")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AccessTokenDTO>> Refresh([FromBody] RefreshTokenDTO dto)
        {
            return Ok(await _authService.RefreshToken(dto));
        }

        [HttpPost("revoke")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RevokeRefreshToken([FromBody] RevokeRefreshTokenDTO dto)
        {
            int.TryParse(User.Claims.FirstOrDefault(x => x.Type == "id").Value, out int userId);

            if (userId <= 0)
            {
                throw new InvalidTokenException("refresh");
            }

            await _authService.RevokeRefreshToken(dto.RefreshToken, userId);
            return Ok();
        }
    }
}