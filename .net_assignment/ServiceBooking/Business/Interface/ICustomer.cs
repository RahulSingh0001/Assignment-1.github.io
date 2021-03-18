using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface ICustomer
    {
        CustomerModel GetCustomer(int? Id);
        IEnumerable<CustomerModel> GetAllCustomer();
        string CreateCustomer(CustomerModel model);
        string UpdateCustomer(CustomerModel model);
        string DeleteCustomer(int? Id);
    }
}
