using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread.NET.BLL.Services;
using Thread.NET.Common.DTO.User;
using Thread.NET.Common.Logic.Abstractions;
using Thread.NET.Extensions;

namespace Thread.NET.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IUserIdGetter _userIdGetter;

        public UsersController(UserService userService, IUserIdGetter userIdGetter)
        {
            _userService = userService;
            _userIdGetter = userIdGetter;
        }

        /// <summary>
        /// Get list of all users
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<UserDTO>>> Get()
        {
            return Ok(await _userService.GetUsers());
        }

        /// <summary>
        /// Get user information by ID
        /// </summary>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDTO>> GetById(int id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        /// <summary>
        /// Get current user based on token
        /// </summary>
        [HttpGet("fromToken")]
        public async Task<ActionResult<UserDTO>> GetUserFromToken()
        {
            return Ok(await _userService.GetUserById(_userIdGetter.CurrentUserId));
        }

        /// <summary>
        /// Update user
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UserDTO user)
        {
            await _userService.UpdateUser(user);
            return NoContent();
        }

        /// <summary>
        /// Delete user by id
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
