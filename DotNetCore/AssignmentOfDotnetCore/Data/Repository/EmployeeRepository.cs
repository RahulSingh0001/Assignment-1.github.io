using AutoMapper;
using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public EmployeeRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public string CreateEmployee(EmployeeViewModel model)
        {
            if (model != null)
            {
                Employee entity = _mapper.Map<EmployeeViewModel, Employee>(model);
                _context.Employee.Add(entity);
                _context.SaveChanges();
                return "Employee added";
            }

            return "Model is null";
        }

        public string DeleteEmployee(int? Id)
        {
            Employee entity = _context.Employee.Find(Id);
            _context.Employee.Remove(entity);
            _context.SaveChanges();
            return "Deleted";
        }

        public IList<EmployeeViewModel> GetAllEmployees()
        {
            IList<EmployeeViewModel> EmployeeList = new List<EmployeeViewModel>();
            var result = _context.Employee.ToList();

            for (int i = 0; i < result.Count; i++)
            {
                EmployeeViewModel employee = _mapper.Map<EmployeeViewModel>(result[i]);
                EmployeeList.Add(employee);
            }
            return EmployeeList;
        }

        public EmployeeViewModel GetEmployee(int? Id)
        {
            EmployeeViewModel employeesEntities = _mapper.Map<EmployeeViewModel>(_context.Employee.Find(Id));
            return employeesEntities;
        }

        public string UpdateEmployee(EmployeeViewModel model)
        {
            if (model != null)
            {
                Employee entity = _context.Employee.Find(model.Id);
                _mapper.Map(model, entity);
                _context.Update(entity);
                _context.SaveChanges();
                return "Employee added";
            }

            return "Model is null";
        }
    }
    
}
