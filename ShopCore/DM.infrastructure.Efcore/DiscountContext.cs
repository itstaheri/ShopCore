using DM.Domain.ColleagueDiscount;
using DM.Domain.CustomerDiscount;
using DM.infrastructure.Efcore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

namespace DM.infrastructure.Efcore
{
    public class DiscountContext : DbContext
    {
        public DiscountContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CustomerDiscountModel>  customerDiscounts { get; set; }
        public DbSet<ColleagueDiscountModel> colleagueDiscounts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ColleagueDiscountMap());
            builder.ApplyConfiguration(new CustomerDiscountMap());
            base.OnModelCreating(builder);
            
        }
    }
}
