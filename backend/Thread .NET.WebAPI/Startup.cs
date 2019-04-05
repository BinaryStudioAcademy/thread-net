using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Thread_.NET.DAL.Context;
using Thread_.NET.Filters;

namespace Thread_.NET
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ThreadContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ThreadDBConnection")));
            services.RegisterAutoMapper();

            services.RegisterCustomServices();
            services.RegisterCustomValidators();

            services
                .AddMvcCore(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .AddJsonFormatters()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation();

            services.ConfigureCustomValidationErrors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
