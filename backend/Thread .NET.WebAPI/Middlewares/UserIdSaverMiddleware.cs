using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.Common.Logic.Abstractions;

namespace Thread_.NET.Middlewares
{
    public class UserIdSaverMiddleware 
    {
        private readonly RequestDelegate _next;

        public UserIdSaverMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IUserIdSetter userIdSetter)
        {
            var claimsUserId = context.User.Claims.FirstOrDefault(x => x.Type == "id")?.Value;
            
            if (claimsUserId != null && int.TryParse(claimsUserId, out int userId))
            {
                userIdSetter.SetUserId(userId);
            }

            await _next.Invoke(context);
        }
    }
}
