using System;

namespace Thread_.NET.BLL.Exceptions
{
    public sealed class InvalidTokenException : Exception
    {
        public InvalidTokenException() : base("Invalid token.") { }
    }
}
