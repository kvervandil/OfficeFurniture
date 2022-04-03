using OfficeFurniture.Domain.Models;

namespace OfficeFurniture.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        List<Product> GetAll();
    }
}
