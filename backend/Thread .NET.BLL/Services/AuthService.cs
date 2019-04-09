using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Auth;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Auth;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.Common.Security;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class AuthService : BaseService
    {
        private readonly JwtFactory _jwtFactory;

        public AuthService(ThreadContext context, IMapper mapper, JwtFactory jwtFactory) : base(context, mapper)
        {
            _jwtFactory = jwtFactory;
        }

        public async Task<AccessTokenDTO> Authorize(UserLoginDTO userDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userDto.Username);

            if (user == null)
            {
                throw new NotFoundException(nameof(User));
            }

            if (!SecurityHelper.ValidatePassword(userDto.Password, user.Password, user.Salt))
            {
                throw new InvalidUsernameOrPasswordException();
            }

            var refreshToken = _jwtFactory.GenerateRefreshToken();

            _context.RefreshTokens.Add(new RefreshToken
            {
                Token = refreshToken,
                UserId = user.Id
            });

            await _context.SaveChangesAsync();

            var accessToken = await _jwtFactory.GenerateAccessToken(user.Id, user.UserName);

            return new AccessTokenDTO(accessToken, refreshToken);
        }

        public async Task<AccessTokenDTO> RefreshToken(RefreshTokenDTO dto)
        {
            var claimsPrincipal = _jwtFactory.GetPrincipalFromToken(dto.AccessToken, dto.SigningKey);

            // invalid token/signing key was passed and we can't extract user claims
            if (claimsPrincipal == null)
            {
                throw new InvalidTokenException("access");
            }

            var userId = int.Parse(claimsPrincipal.Claims.First(c => c.Type == "id").Value);
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), userId);
            }

            var rToken = await _context.RefreshTokens.FirstOrDefaultAsync(t => t.Token == dto.RefreshToken && t.UserId == userId);

            if (rToken == null)
            {
                throw new InvalidTokenException("refresh");
            }

            if (!rToken.IsActive)
            {
                throw new ExpiredRefreshTokenException();
            }

            var jwtToken = await _jwtFactory.GenerateAccessToken(user.Id, user.UserName);
            var refreshToken = _jwtFactory.GenerateRefreshToken();

            _context.RefreshTokens.Remove(rToken); // delete the token we've exchanged
            _context.RefreshTokens.Add(new RefreshToken // add the new one
            {
                Token = refreshToken,
                UserId = user.Id
            });

            await _context.SaveChangesAsync();

            return new AccessTokenDTO(jwtToken, refreshToken);
        }

        public async Task RevokeRefreshToken(string refreshToken, int userId)
        {
            var rToken = _context.RefreshTokens.FirstOrDefault(t => t.Token == refreshToken && t.UserId == userId);

            if (rToken == null)
            {
                throw new InvalidTokenException("refresh");
            }

            _context.RefreshTokens.Remove(rToken);
            await _context.SaveChangesAsync();
        }
    }
}
