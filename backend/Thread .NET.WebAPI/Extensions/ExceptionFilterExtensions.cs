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
            return exception switch
            {
                NotFoundException _ => (HttpStatusCode.NotFound, ErrorCode.NotFound),
                InvalidUsernameOrPasswordException _ => (HttpStatusCode.Unauthorized, ErrorCode.InvalidUsernameOrPassword),
                InvalidTokenException _ => (HttpStatusCode.Unauthorized, ErrorCode.InvalidToken),
                ExpiredRefreshTokenException _ => (HttpStatusCode.Unauthorized, ErrorCode.ExpiredRefreshToken),
                _ => (HttpStatusCode.InternalServerError, ErrorCode.General),
            };
        }
    }
}
