using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SM.Domain.OrderAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<OrderModel>
    {
        public void Configure(EntityTypeBuilder<OrderModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.OwnsMany(x => x.orderDetails, q =>
            {
                q.HasKey(x => x.Id);
                q.WithOwner(x => x.order).HasForeignKey(x => x.OrderId);
                q.HasOne(x => x.product).WithOne(x => x.orderDetail);
            });
        }
    }
}
