using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IService
    {
        ServiceModel GetService(int? Id);
        IEnumerable<ServiceModel> GetAllService();
        string CreateService(ServiceModel model);
        string UpdateService(ServiceModel model);
        string DeleteService(int? Id);
        IEnumerable<BookingStatusModel> GetAllServiceStatus();
    }
}
