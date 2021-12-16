using DM.Application;
using DM.Application.Contract.CustomerDiscount;
using DM.Domain.CustomerDiscount;
using DM.infrastructure.Efcore;
using DM.infrastructure.Efcore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DM.Configuration
{
    public class DiscountBootestrapper
    {
        public static void Configuration(IServiceCollection service, string connectionstring)
        {
            service.AddTransient<ICustomerDiscountRepository, CustomerDiscountRepository>();
            service.AddTransient<ICustomerDiscountApplication, CustomerDiscountApplication>();

            service.AddDbContext<DiscountContext>(x => { x.UseSqlServer(connectionstring); });

        }
    }
}
