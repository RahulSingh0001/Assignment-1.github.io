using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IVehicleRepository
    {
        VehicleModel GetVehicle(int? Id);
        IEnumerable<VehicleModel> GetAllVehicle();
        IEnumerable<VehicleModel> GetAllVehicleByCustomer(int id);
        string CreateVehicle(VehicleModel model);
        string UpdateVehicle(VehicleModel model);
        string DeleteVehicle(int? Id);
    }
}
