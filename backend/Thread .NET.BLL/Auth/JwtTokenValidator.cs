using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace Thread_.NET.BLL.Auth
{
    public sealed class JwtTokenValidator
    {
        private readonly JwtTokenHandler _jwtTokenHandler;

        public JwtTokenValidator(JwtTokenHandler jwtTokenHandler)
        {
            _jwtTokenHandler = jwtTokenHandler;
        }

        public ClaimsPrincipal GetPrincipalFromToken(string token, string signingKey)
        {
            return _jwtTokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey)),
                ValidateLifetime = false // we check expired tokens here
            });
        }
    }
}
