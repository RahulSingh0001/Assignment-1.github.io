//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Digigarage.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public Nullable<int> BookingId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> VehicleId { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Service Service { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
