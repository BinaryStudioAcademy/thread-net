using System;

namespace Thread_.NET.BLL.Exceptions
{
    public sealed class InvalidUsernameOrPasswordException : Exception
    {
        public InvalidUsernameOrPasswordException() : base("Invalid username or password.") { }
    }
}
