using OfficeFurniture.Application.Interfaces;
using OfficeFurniture.Domain.Interfaces;
using OfficeFurniture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<Discount> discounts = _customerRepository.GetDiscountsByCustomerId(customerId);

            throw new NotImplementedException();
        }
    }
}
