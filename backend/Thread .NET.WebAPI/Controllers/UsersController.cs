using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.Extensions;

namespace Thread_.NET.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<UserDTO>>> Get()
        {
            return Ok(await _userService.GetUsers());
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDTO>> GetById(int id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        [HttpGet("fromToken")]
        public async Task<ActionResult<UserDTO>> GetUserFromToken()
        {
            return Ok(await _userService.GetUserById(this.GetUserIdFromToken()));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UserDTO user)
        {
            await _userService.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
