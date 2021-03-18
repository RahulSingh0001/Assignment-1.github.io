using Business.Interface;
using BusinessEntities;
using Data.Repository.Interface;
using System.Collections.Generic;

namespace Business
{
    public class Service : IService
    {
        private readonly IServiceRepository _ServiceRepository;

        public Service(IServiceRepository ServiceRepository)
        {
            _ServiceRepository = ServiceRepository;
        }

        public IEnumerable<ServiceModel> GetAllService()
        {
            return _ServiceRepository.GetAllService();
        }
        public ServiceModel GetService(int? Id)
        {
            return _ServiceRepository.GetService(Id);
        }
        public string CreateService(ServiceModel model)
        {
            return _ServiceRepository.CreateService(model);
        }
        public string UpdateService(ServiceModel model)
        {
            return _ServiceRepository.UpdateService(model);
        }
        public string DeleteService(int? Id)
        {
            return _ServiceRepository.DeleteService(Id);
        }

        public IEnumerable<BookingStatusModel> GetAllServiceStatus()
        {
            return _ServiceRepository.GetAllServiceStatus();
        }
    }
}
