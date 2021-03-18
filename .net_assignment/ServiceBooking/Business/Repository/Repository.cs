﻿using Data.Repository;
using Data.Repository.Interface;
using Unity;
using Unity.Extension;

namespace Business.Repository
{
    public class Repository : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICustomerRepository, CustomerRepository>();
            Container.RegisterType<IMechanicRepository, MechanicRepository>();
            Container.RegisterType<IVehicleRepository, VehicleRepository>();
            Container.RegisterType<ILoginRepository, LoginRepository>();
            Container.RegisterType<IServiceRepository, ServiceRepository>();
            Container.RegisterType<IBookingRepository, BookingRepository>();
        }
    }
}
