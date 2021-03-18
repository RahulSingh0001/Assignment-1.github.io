using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IBookingRepository
    {
        BookingModel GetBooking(int? Id);
        IEnumerable<BookingModel> GetAllBooking();
        IEnumerable<BookingModel> GetAllBookingByCustomer(int id);
        string CreateBooking(BookingModel model);
        string UpdateBooking(BookingModel model);
        string DeleteBooking(int? Id);
    }
}
