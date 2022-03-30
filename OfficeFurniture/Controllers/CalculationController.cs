using Microsoft.AspNetCore.Mvc;
using System;

namespace OfficeFurniture.Controllers
{
    public class CalculationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(int customerId, int furnitureId)
        {



            throw new NotImplementedException();
        }
    }
}
