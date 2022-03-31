using OfficeFurniture.Domain.Models;

namespace OfficeFurniture.Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
