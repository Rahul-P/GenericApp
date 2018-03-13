using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//dotnet ef migrations add 3March18_1_FirstEver
//dotnet ef database update
//dotnet ef migrations remove

//Main command : dotnet ef --startup-project "..\GenericApp" database update
//from- 
//PS C:\ShiTiLikes\GenericApp\GenericApp.Data> dotnet ef --startup-project "..\GenericApp" database update

namespace GenericApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GenericAppContext>
                (options =>
                {
                    options.UseSqlServer
                    ("Server = DESKTOP-8E34R4N\\SQLEXPRESS; Database = GenericDB; Trusted_Connection = True;");

                });       

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
