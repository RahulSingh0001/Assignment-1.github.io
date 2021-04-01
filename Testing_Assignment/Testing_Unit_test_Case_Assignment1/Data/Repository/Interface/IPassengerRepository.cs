using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IPassengerRepository
    {
        string PassengerCreation(PassengerViewModel model);
        bool PassengerDelete(int? Id);
        PassengerViewModel GetPassneger(int? Id);
        List<PassengerViewModel> GetAllPassengers();
        string UpdatePassneger(int id, PassengerViewModel model);
        string PassengerUpdate(int id, PassengerViewModel model);
    }
}
