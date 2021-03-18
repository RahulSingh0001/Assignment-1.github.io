using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerTests.TestRepository
{
    public class TestVehicleRepository : IVehicleRepository
    {
        private List<VehicleModel> _dbContext = new List<VehicleModel>
        {
            new VehicleModel{
                VehicleId = 1,
                LicencePlate = "RJ0S7P2275",
                Model = "Swift Desire",
                Brand = "Mahindra",
                RegistraionDate = DateTime.Now,
                ChassiNo = "CG894211658HIP11",
                CustomerId = 1
            }
        };

        public string CreateVehicle(VehicleModel model)
        {
            if (model != null)
            {
                int Vehicle = _dbContext.Where(a => a.VehicleId == model.VehicleId).Count();
                if (Vehicle > 0)
                {
                    return "Exist";
                }
                _dbContext.Add(model);
                return "Vehicle added";
            }

            return "Model is null";
        }

        public string DeleteVehicle(int? Id)
        {
            int id = (int)Id;
            VehicleModel VehicleEntitie = _dbContext.Where(s => s.VehicleId == id).First();
            _dbContext.Remove(VehicleEntitie);
            return "Deleted";
        }

        public IEnumerable<VehicleModel> GetAllVehicle()
        {
            IEnumerable<VehicleModel> VehicleEntities = _dbContext;
            return VehicleEntities;
        }

        public IEnumerable<VehicleModel> GetAllVehicleByCustomer(int id)
        {
            IEnumerable<VehicleModel> Vehicle = _dbContext.Where(a => a.CustomerId == id);
            return Vehicle;
        }

        public VehicleModel GetVehicle(int? Id)
        {
            int id = (int)Id;
            VehicleModel VehiclesEntities = _dbContext.Where(s => s.VehicleId == id).First();
            return VehiclesEntities;
        }

        public string UpdateVehicle(VehicleModel model)
        {
            if (model != null)
            {
                _dbContext.Add(model);
                return "Vehicle updated";
            }
            return "Model is null";
        }
    }
}
