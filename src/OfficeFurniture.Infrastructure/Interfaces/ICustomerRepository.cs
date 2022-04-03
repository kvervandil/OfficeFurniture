using OfficeFurniture.Domain.Models;

namespace OfficeFurniture.Infrastructure.Interfaces
{
    public interface ICustomerRepository
    {
        List<DiscountBase> GetDiscountsByCustomerId(int customerId);
        List<Customer> GetAllCustomers();
    }
}
