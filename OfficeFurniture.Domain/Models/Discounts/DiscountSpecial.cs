namespace OfficeFurniture.Domain.Models
{
    public class DiscountSpecial : DiscountBase
    {
        public DiscountSpecial(int id, int customerId) : base(id, customerId)
        {
            Value = 40;
        }
    }
}
