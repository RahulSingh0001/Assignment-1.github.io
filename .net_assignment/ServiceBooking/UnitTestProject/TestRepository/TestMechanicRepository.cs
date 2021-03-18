using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerTests.TestRepository
{
    public class TestMechanicRepository : IMechanicRepository
    {
        private List<MechanicModel> _dbContext = new List<MechanicModel>
        {
            new MechanicModel{
                MechanicId =1,
                Name = "shubham",
                MobileNo = "9797979797",
                EmailId = "dummy@gmail.com",
                Brand = "Hero",
            }
        };

        public string CreateMechanic(MechanicModel model)
        {
            if (model != null)
            {
                int Mechanic = _dbContext.Where(a => a.MechanicId == model.MechanicId).Count();
                if (Mechanic > 0)
                {
                    return "Exist";
                }
                _dbContext.Add(model);
                return "Mechanic added";
            }

            return "Model is null";
        }

        public string DeleteMechanic(int? Id)
        {
            int id = (int)Id;
            MechanicModel MechanicEntitie = _dbContext.Where(s => s.MechanicId == id).First();
            _dbContext.Remove(MechanicEntitie);
            return "Deleted";
        }

        public IEnumerable<MechanicModel> GetAllMechanic()
        {
            IEnumerable<MechanicModel> MechanicEntities = _dbContext;
            return MechanicEntities;
        }

        public MechanicModel GetMechanic(int? Id)
        {
            int id = (int)Id;
            MechanicModel MechanicsEntities = _dbContext.Where(s => s.MechanicId == id).First();
            return MechanicsEntities;
        }

        public string UpdateMechanic(MechanicModel model)
        {
            if (model != null)
            {
                _dbContext.Add(model);
                return "Mechanic updated";
            }
            return "Model is null";
        }
    }
}
