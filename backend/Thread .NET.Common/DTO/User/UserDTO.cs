using Thread_.NET.Common.DTOs.Abstract;

namespace Thread_.NET.Common.DTO.User
{
    public sealed class UserDTO : BaseDTO
    {
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
