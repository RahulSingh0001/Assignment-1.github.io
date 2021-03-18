using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities;
using Data.Model;

namespace Business.Automapper
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile()
        {
            //CreateMap<Dealer, DealerViewModel>();
            //CreateMap<DealerViewModel, Dealer>();

            CreateMap<Data.Model.Customer, CustomerModel>();
            CreateMap<CustomerModel, Data.Model.Customer>();

            CreateMap<Data.Model.Service, ServiceModel>();
            CreateMap<ServiceModel, Data.Model.Service>();

            CreateMap<Data.Model.Mechanic, MechanicModel>();
            CreateMap<MechanicModel, Data.Model.Mechanic>();

            CreateMap<Data.Model.Booking, BookingModel>();
            CreateMap<BookingModel, Data.Model.Booking>();

            CreateMap<Data.Model.Vehicle, VehicleModel>();
            CreateMap<VehicleModel, Data.Model.Vehicle>();

            CreateMap<StautsOfBooking, BookingStatusModel>();
            CreateMap<BookingStatusModel, StautsOfBooking>();
        }
    }
}
