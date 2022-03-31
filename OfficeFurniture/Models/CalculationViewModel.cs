using OfficeFurniture.Domain.Models;

namespace OfficeFurniture.UI.Models
{
    public class CalculationViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }

        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
