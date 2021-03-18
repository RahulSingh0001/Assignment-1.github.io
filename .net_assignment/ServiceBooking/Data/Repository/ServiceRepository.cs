using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using Data.Model;
using AutoMapper;
using System.Data.Entity;
using System.Linq;

namespace Data.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly VehiclesEntities _dbContext;

        public ServiceRepository()
        {
            _dbContext = new VehiclesEntities();
        }
        public string CreateService(ServiceModel model)
        {
            
            if (model != null)
            {
                Service entity = Mapper.Map<ServiceModel,Service>(model);
                _dbContext.Services.Add(entity);
                _dbContext.SaveChanges();
                return "Service added";
            }

            return "Model is null";
        }

        public string DeleteService(int? Id)
        {
            Service entity = _dbContext.Services.Find(Id);
            Booking booking;
            int count = _dbContext.Bookings.Where(a => a.ServiceId == entity.ServiceId).Count();
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    booking = _dbContext.Bookings.Where(a => a.ServiceId == entity.ServiceId).FirstOrDefault();
                    _dbContext.Bookings.Remove(booking);
                    _dbContext.SaveChanges();
                }

            }
            _dbContext.Services.Remove(entity);
            _dbContext.SaveChanges();
            return "Deleted";
        }

        public IEnumerable<ServiceModel> GetAllService()
        {
            IEnumerable<ServiceModel> ServicesEntities =
                Mapper.Map<IEnumerable<ServiceModel>>(_dbContext.Services);
            return ServicesEntities;
        }

        public IEnumerable<BookingStatusModel> GetAllServiceStatus()
        {
            IEnumerable<BookingStatusModel> ServicesStatusEntities =
                Mapper.Map<IEnumerable<BookingStatusModel>>(_dbContext.StautsOfBookings);
            return ServicesStatusEntities;
        }

        public ServiceModel GetService(int? Id)
        {
            ServiceModel ServicesEntitie = Mapper.Map<ServiceModel>(_dbContext.Services.Find(Id));
            return ServicesEntitie;
        }

        public string UpdateService(ServiceModel model)
        {
            if (model != null)
            {
                Service entity = _dbContext.Services.Find(model.ServiceId);
                Mapper.Map(model, entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return "Service updated";
            }

            return "Model is null";
        }
    }
}
