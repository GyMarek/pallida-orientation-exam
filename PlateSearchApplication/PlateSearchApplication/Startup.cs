using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PlateSearchApplication.Entities;
using Microsoft.EntityFrameworkCore;
using PlateSearchApplication.Repositories;

namespace PlateSearchApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=plateSearch;Integrated Security=True;Connect Timeout=30;";

            services.AddMvc();
            services.AddDbContext<CarPlateContext>(options => options.UseSqlServer(connectionstring));
            services.AddSingleton<Models.CarPlate>();
            services.AddScoped<CarPlateRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseMvcWithDefaultRoute();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
