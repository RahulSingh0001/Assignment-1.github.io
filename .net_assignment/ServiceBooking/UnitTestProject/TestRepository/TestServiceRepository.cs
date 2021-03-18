using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerTests.TestRepository
{
    public class TestServiceRepository : IServiceRepository
    {
        private List<ServiceModel> _dbContext = new List<ServiceModel>
        {
            new ServiceModel{
                ServiceId=1,
                ServiceName= "Washing",
                Price=360,
                Duration="30 minutes",
                Active = true
            }
        };
        private List<BookingStatusModel> _dbStatus = new List<BookingStatusModel>
        {
            new BookingStatusModel{
                Id=1,
                Status="Pending"
            }
        };

        public string CreateService(ServiceModel model)
        {
            if (model != null)
            {
                _dbContext.Add(model);
                return "Service added";
            }

            return "Model is null";
        }

        public string DeleteService(int? Id)
        {
            int id = (int)Id;
            ServiceModel ServiceEntitie = _dbContext.Where(s => s.ServiceId == id).First();
            _dbContext.Remove(ServiceEntitie);
            return "Deleted";
        }

        public IEnumerable<ServiceModel> GetAllService()
        {
            IEnumerable<ServiceModel> ServiceEntities = _dbContext;
            return ServiceEntities;
        }

        public IEnumerable<BookingStatusModel> GetAllServiceStatus()
        {
            IEnumerable<BookingStatusModel> ServicesStatusEntities =_dbStatus;
            return ServicesStatusEntities;
        }

        public ServiceModel GetService(int? Id)
        {
            int id = (int)Id;
            ServiceModel ServicesEntities = _dbContext.Where(s => s.ServiceId == id).First();
            return ServicesEntities;
        }

        public string UpdateService(ServiceModel model)
        {
            if (model != null)
            {
                _dbContext.Add(model);
                return "Service updated";
            }
            return "Model is null";
        }
    }
}
