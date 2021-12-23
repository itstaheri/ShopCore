using IM.Domain.Inventory;
using IM.Infrastracture.Efcore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

namespace IM.Infrastracture.Efcore
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }
        public DbSet<InventoryModel> inventory { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new InventoryMap());
            base.OnModelCreating(builder);
        }
    }
}
