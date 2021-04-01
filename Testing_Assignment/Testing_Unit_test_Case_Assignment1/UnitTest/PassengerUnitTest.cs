using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Data.Repository;
using WebAPI.Controllers;
using Business.Interface;
using BusinessEntities;
using System.Web.Http.Results;
using Data;

namespace UnitTest
{
    public class PassengerUnitTest
    {
        
        //Mock is used here
        private readonly Mock<IPassengerManager> mockDataRepository = new Mock<IPassengerManager>();
        private readonly PassengersController _passengerController;
        public PassengerUnitTest()
        {
            _passengerController = new PassengersController(mockDataRepository.Object);
        }




        //Getting Data of all Passengers
        [Fact]
        public void GetAllPassengerCase()
        {
            // Arrange
            var resultObj = mockDataRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var response = _passengerController.GetPassengers();

            // Asert
            Assert.Equal(3, response.Count);

        }


        //User by Id
        [Fact]
        public void GetUserByIdCase()
        {
            // Arrange
            var passenger = new PassengerViewModel();
            passenger.PassengerNumber = 1;
            passenger.FirstName = "Raj";
            passenger.LastName = "Sharma";
            passenger.PhoneNo = "0000000000";

            // Act
            var responseObj = mockDataRepository.Setup(x => x.GetPassneger(passenger.PassengerNumber)).Returns(passenger).FirstOrDefault();
            var result = _passengerController.GetPassenger(passenger.PassengerNumber);
          
            // Assert
            Assert.NotNull(result);
        }




        //Function to add user
        [Fact]
        public void AddUserCase()
        {
            var newPassenger = new PassengerViewModel();
            newPassenger.PassengerNumber = 4;
            newPassenger.FirstName = "Amitabh";
            newPassenger.LastName = "Bachan";
            newPassenger.PhoneNo = "9999999999";
            // Act
            var response = mockDataRepository.Setup(x => x.PassengerCreation(newPassenger)).Returns("Added succeffuly");
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.NotNull(result);
        }
       



        //Update User function
        [Fact]
        public void UpdateUserCase()
        {
            // Arrange
            var UpdatePassenger = new PassengerViewModel();
            UpdatePassenger.PassengerNumber = 4;
            UpdatePassenger.FirstName = "Ravi";
            UpdatePassenger.LastName = "Bhai";
            UpdatePassenger.PhoneNo = "3333333333";

            // Act
            var resultObj = mockDataRepository.Setup(x => x.PassengerUpdate(4,UpdatePassenger)).Returns("Passenger updated");
            var response = _passengerController.PutPassenger(4,UpdatePassenger);
            // Assert
            Assert.Equal("Passenger updated",response);
        }






        //Delete User Function
        [Fact]  
        public void DeleteUserCase()
        {
            var passenger = new PassengerViewModel();
            passenger.PassengerNumber = 1;
            // Arrange
            var resultObj = mockDataRepository.Setup(x => x.PassengerDelete(passenger.PassengerNumber)).Returns(true).FirstOrDefault();

            // Act
            var response = _passengerController.DeletePassenger(passenger.PassengerNumber);

            //Assert
            Assert.True(response);

        }
        



        private static List<PassengerViewModel> GetPassenger()
        {
            List<PassengerViewModel> users = new List<PassengerViewModel>()
            {
                new PassengerViewModel() {PassengerNumber=1,FirstName="Raj",LastName="Sharma",PhoneNo="0000000000"},
                new PassengerViewModel() {PassengerNumber=1,FirstName="Amitabh",LastName="singh",PhoneNo="9999999999"},
                new PassengerViewModel() {PassengerNumber=1,FirstName="Ravi",LastName="Bhakt",PhoneNo="3333333333"},

            };
            return users;
        }
        
    }
}
