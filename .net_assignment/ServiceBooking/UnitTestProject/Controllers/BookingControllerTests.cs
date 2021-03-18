using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dealer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interface;
using BusinessEntities;
using System.Web.Mvc;
using Business;
using DealerTests.TestRepository;

namespace Dealer.Controllers.Tests
{
    [TestClass()]
    public class BookingControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            CustomersController controller = new CustomersController(new Customer(new TestCustomerRepository()));
            CustomerModel customer = new CustomerModel()
            {
                CustomerId = 1,
                Name = "Rahul_Singh",
                Address1 = "Udaipur",
                Address2 = "Rajasthan",
                Zipcode = 313003,
                PhoneNo = "7979988172",
                HomePhone = "0000",
                EmailId = "cscrahul001@gmail.com",
                Password = "001100",
            };
            // Act
            ViewResult result = controller.Index(customer) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod()]
        public void EditTest()
        {
            // Arrange
            CustomersController controller = new CustomersController(new Customer(new TestCustomerRepository()));

            // Act
            ViewResult result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod()]
        public void DetailsTest()
        {
            // Arrange
            CustomersController controller = new CustomersController(new Customer(new TestCustomerRepository()));

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod()]
        public void DeleteTest()
        {
            // Arrange
            CustomersController controller = new CustomersController(new Customer(new TestCustomerRepository()));

            // Act
            ViewResult result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}