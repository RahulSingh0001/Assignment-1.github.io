using Business;
using Business.Interface;
using Business.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Users
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ILogin, Login>();
            container.RegisterType<ICustomer, Customer>();
            container.RegisterType<IVehicle, Vehicle>();
            container.RegisterType<IBooking, Booking>();
            container.RegisterType<IService, Service>();
            container.AddNewExtension<Repository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}