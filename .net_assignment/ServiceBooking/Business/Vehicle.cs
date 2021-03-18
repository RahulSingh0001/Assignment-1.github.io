using Business.Interface;
using BusinessEntities;
using Data.Repository.Interface;
using System.Collections.Generic;

namespace Business
{
    public class Vehicle : IVehicle
    {
        private readonly IVehicleRepository _VehicleRepository;

        public Vehicle(IVehicleRepository VehicleRepository)
        {
            _VehicleRepository = VehicleRepository;
        }

        public IEnumerable<VehicleModel> GetAllVehicle()
        {
            return _VehicleRepository.GetAllVehicle();
        }
        public VehicleModel GetVehicle(int? Id)
        {
            return _VehicleRepository.GetVehicle(Id);
        }
        public string CreateVehicle(VehicleModel model)
        {
            return _VehicleRepository.CreateVehicle(model);
        }
        public string UpdateVehicle(VehicleModel model)
        {
            return _VehicleRepository.UpdateVehicle(model);
        }
        public string DeleteVehicle(int? Id)
        {
            return _VehicleRepository.DeleteVehicle(Id);
        }
        public IEnumerable<VehicleModel> GetAllVehicleByCustomer(int id)
        {
            return _VehicleRepository.GetAllVehicleByCustomer(id);
        }
    }
}
