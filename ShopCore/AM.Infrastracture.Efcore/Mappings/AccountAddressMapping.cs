using AM.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastracture.Efcore.Mappings
{
    public class AccountAddressMapping : IEntityTypeConfiguration<AccountAddressModel>
    {
        public void Configure(EntityTypeBuilder<AccountAddressModel> builder)
        {
            builder.HasKey(x => x.Id);
       
        }
    }
}
