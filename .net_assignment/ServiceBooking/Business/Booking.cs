using Business.Interface;
using BusinessEntities;
using Data.Repository.Interface;
using System.Collections.Generic;

namespace Business
{
    public class Booking : IBooking
    {
        private readonly IBookingRepository _BookingRepository;

        public Booking(IBookingRepository BookingRepository)
        {
            _BookingRepository = BookingRepository;
        }

        public IEnumerable<BookingModel> GetAllBooking()
        {
            return _BookingRepository.GetAllBooking();
        }
        public BookingModel GetBooking(int? Id)
        {
            return _BookingRepository.GetBooking(Id);
        }
        public string CreateBooking(BookingModel model)
        {
            return _BookingRepository.CreateBooking(model);
        }
        public string UpdateBooking(BookingModel model)
        {
            return _BookingRepository.UpdateBooking(model);
        }
        public string DeleteBooking(int? Id)
        {
            return _BookingRepository.DeleteBooking(Id);
        }
        public IEnumerable<BookingModel> GetAllBookingByCustomer(int id)
        {
            return _BookingRepository.GetAllBookingByCustomer(id);
        }
    }
}
