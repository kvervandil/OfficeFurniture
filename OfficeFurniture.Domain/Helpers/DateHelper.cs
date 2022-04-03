namespace OfficeFurniture.Domain.Helpers
{
    public class DateHelper : IDateHelper
    {
        public DateTime GetCurrentDate() 
        {
            return DateTime.Now;
        }
    }
}
