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
    public class RegisterController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly AuthService _authService;

        public RegisterController(UserService userService, AuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRegisterDTO user)
        {
            var createdUser = await _userService.CreateUser(user);
            var token = await _authService.GenerateAccessToken(createdUser.Id, createdUser.UserName, createdUser.Email);

            var result = new AuthUserDTO
            {
                User = createdUser,
                Token = token
            };

            return CreatedAtAction("GetById", "users", new { id = createdUser.Id }, result);
        }
    }
}