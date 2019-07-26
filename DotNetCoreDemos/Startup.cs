using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDemos.Models;
using DotNetCoreDemos.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreDemos
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<ICalculate, KDV18>();
           // services.AddScoped<ICalculate, KDV8>(); new gibi
            services.AddTransient<ICalculate, KDV18>();


            services.AddMvc();

            var connection = @"Server = msariel\SQLEXPRESS; Database = mvcDemodb; Trusted_Connection = true";

            services.AddDbContext<BlogContex>(option => option.UseSqlServer(connection,null));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(ConfigureRoutes);
           
          
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

            routeBuilder.MapRoute("mycalculate", "{controller=Calculate}/{action=Calculate}/{id?}");

            routeBuilder.MapRoute("MyRoute", "mustafa/{controller=employee}/{action=add}/{id?}");
        }
    }
}
