
using Microsoft.EntityFrameworkCore;
using SM.Domain.OrderAgg;
using SM.Domain.Product;
using SM.Domain.ProductCategory;
using SM.Domain.ProductComment;
using SM.Domain.Sliders;
using SM.Infrastructure.EfCore.Mappings;
using System;

namespace SM.Infrastructure.EfCore
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<ProductCategoryModel> productcategories { get; set; }
        public DbSet<ProductModel> products { get; set; }
        public DbSet<ShopSliderModel> shopSliders { get; set; }
        public DbSet<ProductCommentModel> productComments { get; set; }
        public DbSet<OrderModel> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OrderMapping());
            builder.ApplyConfiguration(new ProductCategoryMapping());
            builder.ApplyConfiguration(new ProductMapping());
            base.OnModelCreating(builder);
        }
    }
}
