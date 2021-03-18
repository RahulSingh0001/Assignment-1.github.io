using Business;
using Business.Interface;
using Business.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Dealer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
           
            container.RegisterType<ICustomer, Customer>();
            container.RegisterType<IVehicle, Vehicle>();
            container.RegisterType<IMechanic, Mechanic>();
            container.RegisterType<IService, Service>();
            container.RegisterType<IBooking, Booking>();

            container.AddNewExtension<Repository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}