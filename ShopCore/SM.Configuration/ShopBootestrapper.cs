using SM.Application;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Query.Contract.Product;
using Query.Contract.Product.ProductComment;
using Query.Contract.Productcategory;
using Query.Contract.Slider;
using Query.ProductQuery;
using SM.Application;
using SM.Application.Contracts.Order;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;
using SM.Application.Contracts.ProductComment;
using SM.Application.Contracts.Slider;
using SM.Domain.OrderAgg;
using SM.Domain.Product;
using SM.Domain.ProductCategory;
using SM.Domain.ProductComment;
using SM.Domain.Sliders;
using SM.Infrastracture.Efcore.Permisions;
using SM.Infrastructure.EfCore;
using SM.Infrastructure.EfCore.Repositories;
using System;
using AM.Application;

namespace SM.Configuration
{
    public class ShopBootestrapper
    {
        public static void Configuration(IServiceCollection service, string ConnectionString)
        {
            service.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            service.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            service.AddDbContext<ShopContext>(x => { x.UseSqlServer(ConnectionString); });

            service.AddTransient<IProductApplication, ProductApplication>();
            service.AddTransient<IProductRepository, ProductRepository>();

            service.AddTransient<IShopSliderRepository, ShopSliderRepository>();
            service.AddTransient<IShopSliderApplication, ShopSliderApplication>();

            service.AddTransient<IProductcategoryQuery, ProductCategoryQuery>();
            service.AddTransient<ISliderQuary, SliderQuary>();
            service.AddTransient<IProductQueryRepository, ProductQueryRepository>();

            service.AddTransient<IProductCommentRepository, ProductCommentRepository>();
            service.AddTransient<IProductcommentapplication, ProductCommentapplication>();
            service.AddTransient<IProductCommentQueryRepository, ProductCommentQueryRepository>();

            service.AddTransient<IPermisionExposer, ShopPermisionExposer>();

            service.AddTransient<IOrderApplication,OrderApplication>();
            service.AddTransient<IOrderRepository, OrderRepository>();

            service.AddSingleton<ICartService, CartService>();

        }
    }
}
