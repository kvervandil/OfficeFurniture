using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
