using DM.Domain.CustomerDiscount;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.infrastructure.Efcore.Mapping
{
    public class CustomerDiscountMap : IEntityTypeConfiguration<CustomerDiscountModel>
    {
        public void Configure(EntityTypeBuilder<CustomerDiscountModel> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
