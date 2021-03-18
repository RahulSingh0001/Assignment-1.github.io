using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BookingModel
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public Nullable<int> VehicleId { get; set; }
        [Required]
        public Nullable<int> ServiceId { get; set; }
        [Required]
        public Nullable<System.DateTime> StartBookingDate { get; set; }
        [Required]
        public Nullable<System.DateTime> EndBookingDate { get; set; }
        public Nullable<int> MechanicId { get; set; }
        public Nullable<int> Status { get; set; }

        public virtual MechanicModel Mechanic { get; set; }
        public virtual ServiceModel Service { get; set; }
        public virtual VehicleModel Vehicle { get; set; }
        public virtual BookingStatusModel StautsOfBooking { get; set; }
        public IEnumerable<BookingModel> bookinglist { get; set; }
    }
}
