using OfficeFurniture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeFurniture.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
    }
}
