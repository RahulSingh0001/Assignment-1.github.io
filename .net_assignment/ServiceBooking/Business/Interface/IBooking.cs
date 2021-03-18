using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IBooking
    {
        BookingModel GetBooking(int? Id);
        IEnumerable<BookingModel> GetAllBooking();
        string CreateBooking(BookingModel model);
        IEnumerable<BookingModel> GetAllBookingByCustomer(int id);
        string UpdateBooking(BookingModel model);
        string DeleteBooking(int? Id);
    }
}
