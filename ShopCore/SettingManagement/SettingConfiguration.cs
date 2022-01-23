using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingManagement
{
    public class SettingConfiguration
    {
        public static void Configure(IServiceCollection service, string connectionstring)
        {
            service.AddTransient<ISettingRepository, SettingRepository>();
            service.AddDbContext<SettingContext>(x => { x.UseSqlServer(connectionstring); });
        }
    }
}
