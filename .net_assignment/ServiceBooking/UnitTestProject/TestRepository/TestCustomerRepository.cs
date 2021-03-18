using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerTests.TestRepository
{
    public class TestCustomerRepository : ICustomerRepository
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
        public string CreateCustomer(CustomerModel model)
        {
            if (model != null)
            {
                int customer = _dbContext.Where(a => a.EmailId == model.EmailId).Count();
                if (customer > 0)
                {
                    return "Exist";
                }
                _dbContext.Add(model);
                return "Customer added";
            }

            return "Model is null";
        }

        public string DeleteCustomer(int? Id)
        {
            int id = (int)Id;
            CustomerModel customersEntitie = _dbContext.Where(s => s.CustomerId == id).First();
            _dbContext.Remove(customersEntitie);
            return "Deleted";
        }

        public IEnumerable<CustomerModel> GetAllCustomer()
        {
            IEnumerable<CustomerModel> customersEntities = _dbContext;
            return customersEntities;
        }

        public CustomerModel GetCustomer(int? Id)
        {
            int id = (int)Id;
            CustomerModel customersEntitie = _dbContext.Where(s=>s.CustomerId == id).First();
            return customersEntitie;
        }

        public string UpdateCustomer(CustomerModel model)
        {
            if (model != null)
            {
                
                _dbContext.Add(model);
                return "Customer updated";
            }
            return "Model is null";
        }
    }
}
