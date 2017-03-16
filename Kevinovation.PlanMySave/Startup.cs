using Kevinovation.PlanMySave.Data.Context;
using Kevinovation.PlanMySave.Data.Contract;
using Kevinovation.PlanMySave.Data.Repository;
using Kevinovation.PlanMySave.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Kevinovation.PlanMySave
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddApiVersioning();
            services.AddEntityFrameworkNpgsql().AddDbContext<PlanMySaveContext>(options => options.UseNpgsql(Configuration.GetConnectionString("PostgreSQLConnection")));

            this.ConfigureDataAccess(services);
            this.ConfigureService(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }

        private void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<IRevenuService, RevenuService>();
        }

        private void ConfigureDataAccess(IServiceCollection services)
        {
            services.AddScoped<IRevenuRepository, RevenuRepository>();
        }
    }
}