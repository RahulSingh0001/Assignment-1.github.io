using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IMechanic
    {
        MechanicModel GetMechanic(int? Id);
        IEnumerable<MechanicModel> GetAllMechanic();
        string CreateMechanic(MechanicModel model);
        string UpdateMechanic(MechanicModel model);
        string DeleteMechanic(int? Id);
    }
    
}
