using AM.Domain.AccountAgg;
using AM.Domain.Role;
using AM.Infrastracture.Efcore.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastracture.Efcore
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {

        }
        public DbSet<AccountModel> accounts { get; set; }
        public DbSet<RoleModel> roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AccountMapping());
            builder.ApplyConfiguration(new RoleMapping());
            base.OnModelCreating(builder);
        }
    }
}
