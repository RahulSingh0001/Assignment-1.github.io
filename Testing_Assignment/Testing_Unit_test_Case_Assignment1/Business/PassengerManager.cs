using Business.Interface;
using BusinessEntities;
using Data;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PassengerManager : IPassengerManager
    {
        private readonly IPassengerRepository _PassengerRepository;

        public PassengerManager(IPassengerRepository PassengerRepository)
        {
            _PassengerRepository = PassengerRepository;
        }

        public string PassengerCreation(PassengerViewModel model)
        {
            return _PassengerRepository.PassengerCreation(model);
        }

        public bool PassengerDelete(int? Id)
        {
            return _PassengerRepository.PassengerDelete(Id);
        }

        public List<PassengerViewModel> GetAllPassengers()
        {
            return _PassengerRepository.GetAllPassengers();
        }

        public PassengerViewModel GetPassneger(int? Id)
        {
            return _PassengerRepository.GetPassneger(Id);
        }

        public string PassengerUpdate(int id, PassengerViewModel model)
        {
            return _PassengerRepository.PassengerUpdate(id, model);
        }
    }
}
