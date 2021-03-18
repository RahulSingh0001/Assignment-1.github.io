using Business.Interface;
using BusinessEntities;
using Data.Repository.Interface;
using System.Collections.Generic;

namespace Business
{
    public class Mechanic : IMechanic
    {
        private readonly IMechanicRepository _MechanicRepository;

        public Mechanic(IMechanicRepository MechanicRepository)
        {
            _MechanicRepository = MechanicRepository;
        }

        public IEnumerable<MechanicModel> GetAllMechanic()
        {
            return _MechanicRepository.GetAllMechanic();
        }
        public MechanicModel GetMechanic(int? Id)
        {
            return _MechanicRepository.GetMechanic(Id);
        }
        public string CreateMechanic(MechanicModel model)
        {
            return _MechanicRepository.CreateMechanic(model);
        }
        public string UpdateMechanic(MechanicModel model)
        {
            return _MechanicRepository.UpdateMechanic(model);
        }
        public string DeleteMechanic(int? Id)
        {
            return _MechanicRepository.DeleteMechanic(Id);
        }
    }
}
