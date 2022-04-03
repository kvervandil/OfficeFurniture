namespace OfficeFurniture.Domain.Models
{
    public abstract class DiscountBase
    {
        public DiscountBase(int id, int customerId)
        {
            Id = id;
            CustomerId = customerId;
        }

        public int Id { get; set; }
        public decimal Value { get; set; }
        public int CustomerId { get; set; }
    }
}
