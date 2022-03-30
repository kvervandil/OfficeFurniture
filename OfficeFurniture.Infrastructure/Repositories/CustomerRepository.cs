using OfficeFurniture.Domain.Interfaces;
using OfficeFurniture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeFurniture.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Discount> GetDiscountsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
