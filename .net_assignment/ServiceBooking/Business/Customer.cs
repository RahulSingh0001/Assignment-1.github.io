using Business.Interface;
using BusinessEntities;
using Data.Repository.Interface;
using System.Collections.Generic;

namespace Business
{
    public class Customer : ICustomer
    {
        private readonly ICustomerRepository _CustomerRepository;

        public Customer(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }

        public IEnumerable<CustomerModel> GetAllCustomer()
        {
            return _CustomerRepository.GetAllCustomer();
        }
        public CustomerModel GetCustomer(int? Id)
        {
            return _CustomerRepository.GetCustomer(Id);
        }
        public string CreateCustomer(CustomerModel model)
        {
            return _CustomerRepository.CreateCustomer(model);
        }
        public string UpdateCustomer(CustomerModel model)
        {
            return _CustomerRepository.UpdateCustomer(model);
        }
        public string DeleteCustomer(int? Id)
        {
            return _CustomerRepository.DeleteCustomer(Id);
        }
    }
}
