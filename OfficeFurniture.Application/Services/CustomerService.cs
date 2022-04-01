using OfficeFurniture.Application.Interfaces;
using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;

namespace OfficeFurniture.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAll()
        {
            var customers = _customerRepository.GetAllCustomers();

            return customers;
        }
    }
}
