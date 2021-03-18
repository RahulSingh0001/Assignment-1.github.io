using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerTests.TestRepository
{
    public class TestLoginRepository : ILoginRepository
    {
        private List<CustomerModel> _dbContext = new List<CustomerModel>
        {
            new CustomerModel{
               CustomerId = 1,
                Name = "Rahul_Singh",
                Address1 = "Udaipur",
                Address2 = "Rajasthan",
                Zipcode = 313003,
                PhoneNo = "7979988172",
                HomePhone = "0000",
                EmailId = "cscrahul001@gmail.com",
                Password = "001100", }
        };
        public int validUser(LoginModel objUser)
        {
            var obj = _dbContext.Where(a => a.EmailId.Equals(objUser.emailid) && a.Password.Equals(objUser.password)).FirstOrDefault();
            if (obj != null)
            {
                return obj.CustomerId;
            }
            return 0;
        }
    }
}
