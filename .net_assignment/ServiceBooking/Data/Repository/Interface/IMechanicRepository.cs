using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IMechanicRepository
    {
        MechanicModel GetMechanic(int? Id);
        IEnumerable<MechanicModel> GetAllMechanic();
        string CreateMechanic(MechanicModel model);
        string UpdateMechanic(MechanicModel model);
        string DeleteMechanic(int? Id);
    }
}
