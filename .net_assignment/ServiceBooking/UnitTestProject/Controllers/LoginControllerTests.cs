using Microsoft.VisualStudio.TestTools.UnitTesting;
using Users.Controllers;
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
    public class LoginControllerTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            var logincontroller = new LoginController(new Login(new TestLoginRepository()), new Customer(new TestCustomerRepository()));
            LoginModel login = new LoginModel() { emailid= "akshayraj123@gmail.com",password = "123456" };
            ViewResult result = logincontroller.Login(login) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod()]
        public void SignupTest()
        {
            var logincontroller = new LoginController(new Login(new TestLoginRepository()), new Customer(new TestCustomerRepository()));
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
            ViewResult result = logincontroller.Signup(customer) as ViewResult;
            Assert.IsNotNull(result);
        }
    }

}