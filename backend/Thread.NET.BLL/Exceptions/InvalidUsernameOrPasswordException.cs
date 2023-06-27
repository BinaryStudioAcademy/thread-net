using System;

namespace Thread.NET.BLL.Exceptions
{
    public sealed class InvalidUsernameOrPasswordException : Exception
    {
        public InvalidUsernameOrPasswordException() : base("Invalid username or password.") { }
    }
}
