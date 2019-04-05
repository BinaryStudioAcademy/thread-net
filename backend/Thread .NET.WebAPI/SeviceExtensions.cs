using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Thread_.NET.BLL;
using Thread_.NET.BLL.Validators;
using Thread_.NET.Common.DTOs;

namespace Thread_.NET
{
    public static class SeviceExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>();
        }

        public static void RegisterCustomValidators(this IServiceCollection services)
        {
            services.AddSingleton<IValidator<UserDTO>, UserDTOValidator>();
        }

        public static void ConfigureCustomValidationErrors(this IServiceCollection services)
        {
            // override modelstate
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (context) =>
                {
                    var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(p => p.ErrorMessage)).ToList();
                    var result = new
                    {
                        Message = "Validation errors",
                        Errors = errors
                    };

                    return new BadRequestObjectResult(result);
                };
            });
        }
    }
}
