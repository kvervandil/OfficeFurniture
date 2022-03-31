namespace OfficeFurniture.Domain.Models
{
    public class DiscountVolume : DiscountBase
    {
        public DiscountVolume(int id, int customerId, int amount = 1) : base(id, customerId)
        {
            Value = amount switch
            {
                1 => 2,
                2 => 3,
                3 => 4,
                _ => 0,
            };
        }
    }
}
