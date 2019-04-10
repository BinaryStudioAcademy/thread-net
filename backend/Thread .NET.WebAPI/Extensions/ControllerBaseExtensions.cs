using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Thread_.NET.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static int GetCurrentUserId(this ControllerBase controller)
        {
            var claimsUserId = controller.User.Claims.FirstOrDefault(x => x.Type == "id").Value;
            return string.IsNullOrEmpty(claimsUserId) ? 0 : int.Parse(claimsUserId);
        }
    }
}
