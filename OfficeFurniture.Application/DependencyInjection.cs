using Microsoft.Extensions.DependencyInjection;
using OfficeFurniture.Application.Interfaces;
using OfficeFurniture.Application.Services;

namespace OfficeFurniture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICalculationService, CalculationService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IProductService, ProductService>();
            
            return services;
        }
    }
}
