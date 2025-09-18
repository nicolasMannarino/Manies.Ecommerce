using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Manies.Ecommerce.Infrastructure.Data;
using Manies.Ecommerce.Infrastructure.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Manies.Ecommerce.Infrastructure.Repository
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
