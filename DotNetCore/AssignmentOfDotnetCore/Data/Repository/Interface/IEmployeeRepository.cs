using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IEmployeeRepository
    {
        IList<EmployeeViewModel> GetAllEmployees();
        EmployeeViewModel GetEmployee(int? Id);
        string CreateEmployee(EmployeeViewModel model);
        string UpdateEmployee(EmployeeViewModel model);
        string DeleteEmployee(int? Id);
    }
}
