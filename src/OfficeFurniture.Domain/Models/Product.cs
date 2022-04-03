namespace OfficeFurniture.Domain.Models
{
    public class Product
    {
        public Product(int id, string name, decimal priceBase)
        {
            Id = id;
            Name = name;
            PriceBase = priceBase;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceBase { get; set; }
    }
}
