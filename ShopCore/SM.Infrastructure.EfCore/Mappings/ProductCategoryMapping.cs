using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SM.Domain.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Mappings
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategoryModel>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName);
            builder.HasMany(x => x.products).WithOne(x => x.productcategory).HasForeignKey(x => x.CategoryId);
        }
    }
}
