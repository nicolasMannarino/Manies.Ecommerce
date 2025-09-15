using Manies.Ecommerce.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Manies.Ecommerce.Domain.Core
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerDomain, CustomerDomain>();
            return services;
        }
    }
}
