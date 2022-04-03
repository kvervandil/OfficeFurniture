namespace OfficeFurniture.Application.Interfaces
{
    public interface ICalculationService
    {
        public decimal GetFinalPrice(int customerId, int productId);
    }
}
