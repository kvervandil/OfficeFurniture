using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;

namespace OfficeFurniture.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public static List<Product> Products => GenerateFakeProducts();


        public Product GetProductById(int productId)
        {
            return Products.Where(product => product.Id == productId).First();
        }

        private static List<Product> GenerateFakeProducts()
        {
            var products = new List<Product>
            {
                new Product(1, "Product1", 1000),
                new Product(2, "Product2", 8000),
                new Product(3, "Product3", 6000),
                new Product(4, "Product4", 4000),
                new Product(5, "Product5", 5000),
            };

            return products;
        }

        public List<Product> GetAll()
        {
            return Products;
        }
    }
}
