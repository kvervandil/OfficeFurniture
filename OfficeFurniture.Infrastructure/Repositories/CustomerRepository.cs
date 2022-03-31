using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;

namespace OfficeFurniture.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public static List<DiscountBase> Discounts => GenerateFakeDiscounts();
        public static List<Customer> Customers => GenerateFakeCustomers();

        public List<DiscountBase> GetDiscountsByCustomerId(int customerId)
        {
            return Discounts.Where(discount => discount.CustomerId == customerId).ToList();
        }


        private static List<DiscountBase> GenerateFakeDiscounts()
        {
            var discounts = new List<DiscountBase>
            {
                new DiscountPeriod(1, 1, DateTime.Now),
                new DiscountSpecial(2, 1),
                new DiscountVolume(3, 1),
                new DiscountVolume(4, 1, 1),
                new DiscountVolume(5, 1),
            };

            return discounts;
        }

        private static List<Customer> GenerateFakeCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer(1, "customer1"),
                new Customer(2, "customer2"),
                new Customer(3, "customer3"),
                new Customer(4, "customer4"),
            };

            return customers;
        }

        public List<Customer> GetAllCustomers()
        {
            return Customers;
        }
    }
}
