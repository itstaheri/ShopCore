using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingManagement
{
    public class SettingContext : DbContext
    {
        public SettingContext(DbContextOptions<SettingContext> options) : base(options)
        {

        }
        public DbSet<SettingModel> setting { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           // builder.Entity<SettingModel>(x => x.HasNoKey());
            base.OnModelCreating(builder);
        }
    }
}
