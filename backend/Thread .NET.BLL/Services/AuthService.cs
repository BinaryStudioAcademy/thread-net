using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Auth;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Auth;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class AuthService : BaseService
    {
        private readonly JwtFactory _jwtFactory;
        private static readonly ISet<string> _refreshTokens;

        static AuthService()
        {
            // Note: better to link with the user and check: only 1 active refresh token for the 1 user
            _refreshTokens = new HashSet<string>();
        }

        public AuthService(ThreadContext context, IMapper mapper, JwtFactory jwtFactory) : base(context, mapper)
        {
            _jwtFactory = jwtFactory;
        }

        public async Task<AccessTokenDTO> Authorize(UserLoginDTO userDto)
        {
            if (!string.IsNullOrEmpty(userDto.Username) && !string.IsNullOrEmpty(userDto.Password))
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userDto.Username && u.Password == userDto.Password);

                if (user != null)
                {
                    var refreshToken = _jwtFactory.GenerateRefreshToken();
                    _refreshTokens.Add(refreshToken);

                    var accessToken = await _jwtFactory.GenerateEncodedToken(user.Id, user.UserName);

                    return new AccessTokenDTO(accessToken, refreshToken);
                }
            }

            throw new InvalidUsernameOrPasswordException();
        }

        public async Task<AccessTokenDTO> RefreshToken(RefreshTokenDTO dto)
        {
            var claimsPrincipal = _jwtFactory.GetPrincipalFromToken(dto.AccessToken, dto.SigningKey);

            // invalid token/signing key was passed and we can't extract user claims
            if (claimsPrincipal != null)
            {
                var userId = int.Parse(claimsPrincipal.Claims.First(c => c.Type == "id").Value);
                var user = await _context.Users.FindAsync(userId);

                if (user == null)
                {
                    throw new NotFoundException(nameof(User), userId);
                }

                var rToken = _refreshTokens.FirstOrDefault(t => t == dto.RefreshToken);

                if (!string.IsNullOrEmpty(rToken))
                {
                    var jwtToken = await _jwtFactory.GenerateEncodedToken(user.Id, user.UserName);
                    var refreshToken = _jwtFactory.GenerateRefreshToken();

                    _refreshTokens.Remove(dto.RefreshToken); // delete the token we've exchanged
                    _refreshTokens.Add(refreshToken); // add the new one

                    return new AccessTokenDTO(jwtToken, refreshToken);
                }
            }

            throw new InvalidTokenException();
        }

        public void RevokeRefreshToken(string refreshToken)
        {
            var rToken = _refreshTokens.FirstOrDefault(t => t == refreshToken);

            if (!string.IsNullOrEmpty(rToken))
            {
                _refreshTokens.Remove(refreshToken);
            }
        }
    }
}
