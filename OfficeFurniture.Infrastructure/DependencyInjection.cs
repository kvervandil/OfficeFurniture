using Microsoft.Extensions.DependencyInjection;
using OfficeFurniture.Infrastructure.Interfaces;
using OfficeFurniture.Infrastructure.Repositories;

namespace OfficeFurniture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
