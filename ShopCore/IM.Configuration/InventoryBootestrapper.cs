using Frameworks;
using IM.Application;
using IM.Application.Contract.Inventory;
using IM.Domain.Inventory;
using IM.Infrastracture.Efcore;
using IM.Infrastracture.Efcore.Permisions;
using IM.Infrastracture.Efcore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IM.Configuration
{
    public class InventoryBootestrapper
    {
        public static void Configoration(IServiceCollection service,string connectionstring)
        {
            service.AddTransient<IInventoryRepository, InventoryRepository>();
            service.AddTransient<IInventoryApplication, InventoryApplication>();
            service.AddDbContext<InventoryContext>(x => { x.UseSqlServer(connectionstring); });

            service.AddTransient<IPermisionExposer, InventoryPermisionExposer>();
        }
    }
}
