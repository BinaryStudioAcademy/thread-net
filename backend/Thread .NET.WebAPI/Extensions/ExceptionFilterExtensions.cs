using System;
using System.Net;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.Enums;

namespace Thread_.NET.Extensions
{
    public static class ExceptionFilterExtensions
    {
        public static (HttpStatusCode statusCode, ErrorCode errorCode) ParseException(this Exception exception)
        {
            switch (exception)
            {
                case NotFoundException _:
                    return (HttpStatusCode.NotFound, ErrorCode.NotFound);
                case InvalidUsernameOrPasswordException _:
                    return (HttpStatusCode.Unauthorized, ErrorCode.InvalidUsernameOrPassword);
                case InvalidTokenException _:
                    return (HttpStatusCode.Unauthorized, ErrorCode.InvalidToken);
                case ExpiredRefreshTokenException _:
                    return (HttpStatusCode.Unauthorized, ErrorCode.ExpiredRefreshToken);
                default:
                    return (HttpStatusCode.InternalServerError, ErrorCode.General);
            }
        }
    }
}
