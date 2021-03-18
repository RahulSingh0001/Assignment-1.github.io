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
    public class MechanicRepository : IMechanicRepository
    {
        private readonly VehiclesEntities _dbContext;

        public MechanicRepository()
        {
            _dbContext = new VehiclesEntities();
        }
        public string CreateMechanic(MechanicModel model)
        {
            if (model != null)
            {
                Mechanic entity = Mapper.Map<MechanicModel, Mechanic>(model);
                _dbContext.Mechanics.Add(entity);
                _dbContext.SaveChanges();
                return "Mechanic added";
            }

            return "Model is null";
        }

        public string DeleteMechanic(int? Id)
        {
            Booking booking;
            Mechanic entity = _dbContext.Mechanics.Find(Id);
            int count = _dbContext.Bookings.Where(a => a.MechanicId == entity.MechanicId).Count();
            if (count != 0)
            {
                for (int j = 0; j < count; j++)
                {
                    booking = _dbContext.Bookings.Where(a => a.MechanicId == entity.MechanicId).FirstOrDefault();
                    _dbContext.Bookings.Remove(booking);
                    _dbContext.SaveChanges();
                }

            }
            _dbContext.Mechanics.Remove(entity);
            _dbContext.SaveChanges();
            return "Deleted";
        }

        public IEnumerable<MechanicModel> GetAllMechanic()
        {
            IEnumerable<MechanicModel> mechanicsEntities =
                Mapper.Map<IEnumerable<MechanicModel>>(_dbContext.Mechanics);
            return mechanicsEntities;
        }

        public MechanicModel GetMechanic(int? Id)
        {
            MechanicModel mechanicsEntities = Mapper.Map<MechanicModel>(_dbContext.Mechanics.Find(Id));
            return mechanicsEntities;
        }

        public string UpdateMechanic(MechanicModel model)
        {
            if (model != null)
            {
                Mechanic entity = _dbContext.Mechanics.Find(model.MechanicId);
                Mapper.Map(model, entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return "Mechanic updated";
            }

            return "Model is null";
        }
    }
}
