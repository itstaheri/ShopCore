using _0_Framework.Application;
using AM.Configuration;
using DM.Configuration;
using DM.infrastructure.Efcore;
using Frameworks;
using IM.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SM.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        string ConnectionString = "Data Source =.; Initial Catalog = ShopCoreDB; Integrated Security = true";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            ShopBootestrapper.Configuration(services, ConnectionString);
            DiscountBootestrapper.Configuration(services, ConnectionString);
            InventoryBootestrapper.Configoration(services, ConnectionString);
            AccountBootestrapper.Configure(services, ConnectionString);

            services.AddTransient<IFileUploader, FileUploader>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
