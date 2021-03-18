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
    public class BookingRepository : IBookingRepository
    {
        private readonly VehiclesEntities _dbContext;

        public BookingRepository()
        {
            _dbContext = new VehiclesEntities();
        }
        public string CreateBooking(BookingModel model)
        {
            if (model != null)
            {
                int noOfBooking = _dbContext.Bookings.Where(a => a.VehicleId == model.VehicleId).Where(a => a.ServiceId == model.ServiceId).Count();
                if (noOfBooking != 0) 
                {
                    return "Exist";
                }
                    Vehicle vech = _dbContext.Vehicles.Where(a => a.VehicleId == model.VehicleId).FirstOrDefault();
                    Mechanic mech = _dbContext.Mechanics.Where(a => a.Brand == vech.Brand).FirstOrDefault();
                    model.MechanicId = mech.MechanicId;
                    model.Status = 1;
                    Booking entity = Mapper.Map<BookingModel, Booking>(model);
                    _dbContext.Bookings.Add(entity);
                    _dbContext.SaveChanges();
                    return "Booking added";
                
            }
            return "Model is null";
        }

        public string DeleteBooking(int? Id)
        {
            Booking entity = _dbContext.Bookings.Find(Id);
            _dbContext.Bookings.Remove(entity);
            _dbContext.SaveChanges();
            return "Deleted";
        }

        public IEnumerable<BookingModel> GetAllBooking()
        {
            IEnumerable<Booking> Booking = _dbContext.Bookings;
            IEnumerable<BookingModel> bookingsEntities =
                Mapper.Map<IEnumerable<BookingModel>>(Booking);
            return bookingsEntities;
        }

        public IEnumerable<BookingModel> GetAllBookingByCustomer(int id)
        {
            IEnumerable<Booking> Booking = _dbContext.Bookings.Where(a => a.CustomerId == id);
            IEnumerable<BookingModel> bookingsEntities =
                Mapper.Map<IEnumerable<BookingModel>>(Booking);
            return bookingsEntities;
        }

        public BookingModel GetBooking(int? Id)
        {
            BookingModel bookingsEntities = Mapper.Map<BookingModel>(_dbContext.Bookings.Find(Id));
            return bookingsEntities;
        }

       
        public string UpdateBooking(BookingModel model)
        {
            if (model != null)
            {
                Booking entity = _dbContext.Bookings.Find(model.BookingId);
                Mapper.Map(model, entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return "Booking updated";
            }
            return "Model is null";
        }
    }
}
