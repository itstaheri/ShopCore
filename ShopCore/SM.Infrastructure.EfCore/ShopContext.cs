using Microsoft.EntityFrameworkCore;
using SM.Domain.ProductCategory;
using System;

namespace SM.Infrastructure.EfCore
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ProductCategoryModel> productcategories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }
    }
}
