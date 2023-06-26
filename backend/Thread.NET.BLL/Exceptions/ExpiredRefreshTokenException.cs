using System;

namespace Thread.NET.BLL.Exceptions
{
    public sealed class ExpiredRefreshTokenException : Exception
    {
        public ExpiredRefreshTokenException() : base("Refresh token expired.") { }
    }
}
