using OfficeFurniture.Domain.Enums;

namespace OfficeFurniture.Domain.Models
{
    public class DiscountPeriod : DiscountBase
    {
        public DiscountPeriod(int id, int customerId, DateTime buyDate) : base(id, customerId)
        {
            Value = buyDate.Month switch
            {
                (int)Months.January => 5,
                (int)Months.February => 4,
                (int)Months.March => 6,
                _ => 3,
            };
        }
    }
}
