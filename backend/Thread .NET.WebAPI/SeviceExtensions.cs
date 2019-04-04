using Microsoft.Extensions.DependencyInjection;
using Thread_.NET.BLL;

namespace Thread_.NET
{
    public static class SeviceExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>();
        }
    }
}
