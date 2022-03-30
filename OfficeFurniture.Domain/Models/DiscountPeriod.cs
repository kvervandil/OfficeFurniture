﻿using OfficeFurniture.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
