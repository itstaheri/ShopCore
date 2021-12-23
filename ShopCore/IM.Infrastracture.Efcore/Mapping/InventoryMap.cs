using IM.Domain.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Infrastracture.Efcore.Mapping
{
    public class InventoryMap : IEntityTypeConfiguration<InventoryModel>
    {
        public void Configure(EntityTypeBuilder<InventoryModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.OwnsMany(x => x.inventoryOperations, modelbuilder =>
            {
                modelbuilder.HasKey(x => x.Id);
                modelbuilder.Property(x => x.Description).HasMaxLength(1200);
                modelbuilder.WithOwner(x => x.inventoryModel).HasForeignKey(x => x.InventoryId);
            });
        }
    }
   
}
