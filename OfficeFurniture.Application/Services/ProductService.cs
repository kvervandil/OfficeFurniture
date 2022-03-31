using OfficeFurniture.Application.Interfaces;
using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;

namespace OfficeFurniture.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
