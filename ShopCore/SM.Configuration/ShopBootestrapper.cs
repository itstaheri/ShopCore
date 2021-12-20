using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Query.Contract.Productcategory;
using Query.Contract.Slider;
using Query.Quary;
using SM.Application;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;
using SM.Application.Contracts.Slider;
using SM.Domain.Product;
using SM.Domain.ProductCategory;
using SM.Domain.Sliders;
using SM.Infrastructure.EfCore;
using SM.Infrastructure.EfCore.Repositories;
using System;

namespace SM.Configuration
{
    public class ShopBootestrapper
    {
        public static void Configuration(IServiceCollection service, string ConnectionString)
        {
            service.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            service.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            service.AddDbContext<ShopContext>(x => { x.UseSqlServer(ConnectionString); });

            service.AddTransient<IProductApplication, ProductAppication>();
            service.AddTransient<IProductRepository, ProductRepository>();

            service.AddTransient<IShopSliderRepository, ShopSliderRepository>();
            service.AddTransient<IShopSliderApplication, ShopSliderApplication>();

            service.AddTransient<IProductcategoryQuery, ProductCategoryQuery>();
            service.AddTransient<ISliderQuary, SliderQuary>();

          


        }
    }
}
