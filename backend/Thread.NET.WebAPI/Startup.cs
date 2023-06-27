using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Thread.NET.BLL.Hubs;
using Thread.NET.DAL.Context;
using Thread.NET.Extensions;
using Thread.NET.Filters;
using Thread.NET.Middlewares;

namespace Thread.NET
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
            var migrationAssembly = typeof(ThreadContext).Assembly.GetName().Name;
            services.AddDbContext<ThreadContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:ThreadDBConnection"], opt => opt.MigrationsAssembly(migrationAssembly)));

            services.RegisterAutoMapper();

            services.RegisterCustomServices();
            services.RegisterCustomValidators();

            services.ConfigureJwt(Configuration);
            services.AddCors();

            services.AddSignalR();

            services
                .AddMvcCore(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .AddAuthorization()
                .AddFluentValidation();

            services.ConfigureCustomValidationErrors();

            services
                .AddEndpointsApiExplorer()
                .AddMvc();
            services.ConfigureSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = string.Empty;
            });

            app.UseCors(builder => builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Token-Expired")
                .AllowCredentials()
                .WithOrigins("http://localhost:4200"));
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware<UserIdSaverMiddleware>();

            app.UseEndpoints(cfg =>
            {
                cfg.MapControllers();
                cfg.MapHub<PostHub>("/notifications/post");
            });

            InitializeDatabase(app);
        }

        private static void InitializeDatabase(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<ThreadContext>();
                context.Database.Migrate();
            };
        }
    }
}