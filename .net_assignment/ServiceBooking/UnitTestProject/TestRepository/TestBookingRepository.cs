using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerTests.TestRepository
{
    public class TestBookingRepository : IBookingRepository
    {
        private List<BookingModel> _dbContext = new List<BookingModel>
        {
            new BookingModel{
                BookingId=1,
                VehicleId=1,
                MechanicId=1,
                StartBookingDate=DateTime.Now,
                EndBookingDate=DateTime.Now,
                CustomerId=1,
                Status=1,
                ServiceId=1,
                }
        };

        public string CreateBooking(BookingModel model)
        {
            if (model != null)
            {
                int booking = _dbContext.Where(a => a.VehicleId == model.VehicleId).Where(a => a.ServiceId == model.ServiceId).Count();
                if (booking > 0)
                {
                    return "Exist";
                }
                _dbContext.Add(model);
                return "Booking added";
            }

            return "Model is null";
        }

        public string DeleteBooking(int? Id)
        {
            int id = (int)Id;
            BookingModel bookingEntitie = _dbContext.Where(s => s.BookingId == id).First();
            _dbContext.Remove(bookingEntitie);
            return "Deleted";
        }

        public IEnumerable<BookingModel> GetAllBooking()
        {
            IEnumerable<BookingModel> bookingEntities = _dbContext;
            return bookingEntities;
        }

        public IEnumerable<BookingModel> GetAllBookingByCustomer(int id)
        {
            IEnumerable<BookingModel> Booking = _dbContext.Where(a => a.CustomerId == id);
            return Booking;
        }

        public BookingModel GetBooking(int? Id)
        {
            int id = (int)Id;
            BookingModel bookingsEntities = _dbContext.Where(s => s.BookingId == id).First();
            return bookingsEntities;
        }

        public string UpdateBooking(BookingModel model)
        {
            if (model != null)
            { 
                _dbContext.Add(model);
                return "Booking updated";
            }
            return "Model is null";
        }
    }
}
