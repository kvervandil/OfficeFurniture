using OfficeFurniture.Domain.Models;

namespace OfficeFurniture.Application.Interfaces
{
    public interface ICustomerService
    {
        public List<Customer> GetAll();
    }
}
