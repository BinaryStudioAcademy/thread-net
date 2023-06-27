﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Thread.NET.BLL.Exceptions;

namespace Thread.NET.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static int GetUserIdFromToken(this ControllerBase controller)
        {
            var claimsUserId = controller.User.Claims.FirstOrDefault(x => x.Type == "id")?.Value;

            if (string.IsNullOrEmpty(claimsUserId))
            {
                throw new InvalidTokenException("access");
            }

            return int.Parse(claimsUserId);
        }
    }
}
