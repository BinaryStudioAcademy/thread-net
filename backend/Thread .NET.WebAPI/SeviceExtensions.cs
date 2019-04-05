using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Thread_.NET.BLL.MappingProfiles;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTOs;
using Thread_.NET.Validators;

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

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<UserProfile>();
            });
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
