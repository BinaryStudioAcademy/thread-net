using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.Enums;

namespace Thread_.NET.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            HttpStatusCode statusCode;
            ErrorCode errorCode;

            switch (context.Exception)
            {
                case NotFoundException _:
                    statusCode = HttpStatusCode.NotFound;
                    errorCode = ErrorCode.NotFound;
                    break;
                case InvalidUsernameOrPasswordException _:
                    statusCode = HttpStatusCode.Unauthorized;
                    errorCode = ErrorCode.InvalidUsernameOrPassword;
                    break;
                case InvalidTokenException _:
                    statusCode = HttpStatusCode.Unauthorized;
                    errorCode = ErrorCode.InvalidToken;
                    break;
                case ExpiredRefreshTokenException _:
                    statusCode = HttpStatusCode.Unauthorized;
                    errorCode = ErrorCode.ExpiredRefreshToken;
                    break;
                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    errorCode = ErrorCode.General;
                    break;
            }

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.Result = new JsonResult(new
            {
                error = context.Exception.Message,
                code = errorCode
            });
        }
    }
}