using AM.Configuration;
using DM.Configuration;
using DM.infrastructure.Efcore;
using Frameworks;
using IM.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Query.Contract.Cart;
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
            services.AddRazorPages().AddMvcOptions(option=>option.Filters.Add<SecurityPageFilter>()).AddRazorPagesOptions(option =>
            {
                option.Conventions.AuthorizeAreaFolder("Admin", "/", "AdminArea");
               // option.Conventions.AuthorizeAreaFolder("Shop", "/", "AdminArea");
            });
            ShopBootestrapper.Configuration(services, ConnectionString);
            DiscountBootestrapper.Configuration(services, ConnectionString);
            InventoryBootestrapper.Configoration(services, ConnectionString);
            AccountBootestrapper.Configure(services, ConnectionString);

            services.AddTransient<IAuthHelper, AuthHelper>();
            services.AddTransient<IFileUploader, FileUploader>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddTransient<ICartCalculator, CartCalculator>();

            // 
            services.AddHttpContextAccessor();

            services.Configure<CookiePolicyOptions>(option =>
            {
                option.CheckConsentNeeded = context => true;
                option.MinimumSameSitePolicy = SameSiteMode.Strict;


            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, q =>
                {
                    q.LoginPath = new PathString("/Account");
                    q.LogoutPath = new PathString("/Account");
                    q.AccessDeniedPath = new PathString("/AccessDenied");
                });

            //Limited
            services.AddAuthorization(option =>
            {
                option.AddPolicy("AdminArea", builder => builder.RequireRole(new List<string> { "1" }));
                //option.AddPolicy("Shop", builder => builder.RequireRole("1"));
            });
            
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
            app.UseAuthentication();
            app.UseCookiePolicy();
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
