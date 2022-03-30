using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeFurniture.Application.Interfaces
{
    public interface ICalculationService
    {
        public decimal GetFinalPrice(int customerId, int productId);
    }
}
