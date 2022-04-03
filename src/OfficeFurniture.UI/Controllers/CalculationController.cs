using Microsoft.AspNetCore.Mvc;
using OfficeFurniture.Application.Interfaces;
using OfficeFurniture.Application.Services;
using OfficeFurniture.UI.Models;
using System;

namespace OfficeFurniture.Controllers
{
    public class CalculationController : Controller
    {
        private readonly ICalculationService _calculationService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public CalculationController(ICalculationService calculationService, ICustomerService customerService, IProductService productService)
        {
            _calculationService = calculationService;
            _customerService = customerService;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var customers = _customerService.GetAll();

            var products = _productService.GetAll();

            var model = new CalculationViewModel { Products = products, Customers = customers};

            return View(model);
        }

        public IActionResult Calculate(CalculationViewModel viewModel)
        {
            var result = _calculationService.GetFinalPrice(viewModel.CustomerId, viewModel.ProductId);

            viewModel.FinalPrice = result;

            return View(viewModel);
        }
    }
}
