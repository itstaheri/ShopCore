using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SM.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.productcategory).WithMany(x => x.products)
                .HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.Comments).WithOne(x => x.product).HasForeignKey(x => x.ProductId);
        //    builder.HasOne(x => x.orderDetail).WithOne(x => x.product);
        }
    }
}
