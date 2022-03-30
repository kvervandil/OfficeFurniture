using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Product(1, "Product1", 8000),
                new Product(1, "Product1", 6000),
                new Product(1, "Product1", 4000),
                new Product(1, "Product1", 5000),
            };

            return products;
        }
    }
}
