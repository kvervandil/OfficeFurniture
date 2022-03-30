using OfficeFurniture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeFurniture.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        List<Discount> GetDiscountsByCustomerId(int customerId);
    }
}
