using OfficeFurniture.Application.Interfaces;
using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;

namespace OfficeFurniture.Application.Services
{
    public class CalculationService : ICalculationService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;

        public CalculationService(IProductRepository productRepository, ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
        }

        public decimal GetFinalPrice(int customerId, int productId)
        {
            List<DiscountBase> discounts = _customerRepository.GetDiscountsByCustomerId(customerId);

            Product product = _productRepository.GetProductById(productId);

            var finalDiscount = discounts.Sum(x => x.Value) / 100;

            return (1 - finalDiscount) * product.PriceBase; 
        }
    }
}
