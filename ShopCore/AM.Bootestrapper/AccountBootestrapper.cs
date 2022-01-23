using AM.Application;
using AM.Application.Contract.Account;
using AM.Application.Contract.Role;
using AM.Domain.AccountAgg;
using AM.Domain.Role;
using AM.Infrastracture.Efcore;
using AM.Infrastracture.Efcore.Repositories;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Query.AccountQuery;
using Query.Contract.Account;
using System;

namespace AM.Configuration
{
    public class AccountBootestrapper
    {

        public static void Configure(IServiceCollection service,string connectionstring)
        {
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<IAccountApplication, AccountApplication>();
            service.AddDbContext<AccountContext>(x => { x.UseSqlServer(connectionstring); });

            service.AddTransient<IRoleRepository, RoleRepository>();
            service.AddTransient<IRoleApplication, RoleApplication>();

            service.AddTransient<IAccountQueryRepository, AccountQueryRepository>();

         
        }
    }
}
