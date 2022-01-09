using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SM.Domain.ProductComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Mappings
{
    public class ProductCommentMapping : IEntityTypeConfiguration<ProductCommentModel>
    {
        public void Configure(EntityTypeBuilder<ProductCommentModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.product).WithMany(x => x.Comments).HasForeignKey(x => x.ProductId);
        }
    }
}
