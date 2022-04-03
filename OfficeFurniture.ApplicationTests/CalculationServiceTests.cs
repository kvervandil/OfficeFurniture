using Moq;
using OfficeFurniture.Application.Services;
using OfficeFurniture.Domain.Helpers;
using OfficeFurniture.Domain.Models;
using OfficeFurniture.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace OfficeFurniture.ApplicationTests
{
    public class CalculationServiceTests
    {
        [Fact]
        public void Should_GetFinalPrice_CalculateCorrectPrice()
        {
            //Arrange
            var productRepository = new Mock<IProductRepository>();
            var customerRepository = new Mock<ICustomerRepository>();
            var dateHelper = new Mock<IDateHelper>();

            var objectUnderTest = new CalculationService(productRepository.Object,
                                                         customerRepository.Object);

            var product = new Product(1, "TestProduct", 2000);

            productRepository.Setup(x => x.GetProductById(product.Id)).Returns(product);
            dateHelper.Setup(x => x.GetCurrentDate()).Returns(new DateTime(2022, 3, 8));


            List<DiscountBase> discounts = new List<DiscountBase>
            {
                new DiscountPeriod(1, 1, dateHelper.Object.GetCurrentDate()),
                new DiscountSpecial(2, 1),
                new DiscountVolume(3, 1, 4)
            };

            customerRepository.Setup(x => x.GetDiscountsByCustomerId(1)).Returns(discounts);

            //Act
            var actualResult = objectUnderTest.GetFinalPrice(1, 1);

            //Assert
            var expectedResult = 1080;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
