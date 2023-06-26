using Thread_.NET.Common.DTO.Auth;

namespace Thread_.NET.Common.DTO.User
{
    public sealed class AuthUserDTO
    {
        public UserDTO User { get; set; }
        public AccessTokenDTO Token { get; set; }
    }
}
