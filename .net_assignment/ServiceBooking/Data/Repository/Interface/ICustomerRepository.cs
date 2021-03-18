using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface ICustomerRepository
    {
        CustomerModel GetCustomer(int? Id);
        IEnumerable<CustomerModel> GetAllCustomer();
        string CreateCustomer(CustomerModel model);
        string UpdateCustomer(CustomerModel model);
        string DeleteCustomer(int? Id);
    }
}
