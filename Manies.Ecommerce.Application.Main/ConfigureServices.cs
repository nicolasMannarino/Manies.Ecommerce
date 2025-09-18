using Manies.Ecommerce.Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Manies.Ecommerce.Application.Main
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
