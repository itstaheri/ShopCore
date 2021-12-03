using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SM.Application;
using SM.Application.Contracts.ProductCategory;
using SM.Domain.ProductCategory;
using SM.Infrastructure.EfCore;
using SM.Infrastructure.EfCore.Repositories;
using System;

namespace SM.Configuration
{
    public class ShopBootestrapper
    {
        public static void Configuration(IServiceCollection service,string ConnectionString)
        {
            service.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            service.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            service.AddDbContext<ShopContext>(x => { x.UseSqlServer(ConnectionString); });
        }
    }
}
