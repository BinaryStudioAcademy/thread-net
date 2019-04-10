using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserService _userService;

        public RegisterController(UserService userService)
        {
            _userService = userService;
        }

        // POST api/register
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Post([FromBody] UserRegisterDTO user)
        {
            var createdUser = await _userService.CreateUser(user);
            return CreatedAtAction("GetById", "users", new { id = createdUser.Id }, createdUser);
        }
    }
}