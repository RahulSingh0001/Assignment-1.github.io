using NUnit.Framework;
using Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceTest
{
    [TestFixture]
    public class Tests
    {
        // Object creation of ServiceClass
        private ServiceClass _services;
        [SetUp] // SetUp runs before execution of method
        public void Setup()
        {
            _services = new ServiceClass();
        }


        // Prime number test case
        [Test]
        public void InputAs1()
        {
            // Act
            var result = _services.IsPrime(1);
            
            // Assert
            Assert.IsFalse(result, "1 should not be prime ");
        }

        
        
        // Different test case for number less than 2
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]

     public void IsPrime_ValueUnder2(int value)
     {
            // Act
         var result = _services.IsPrime(value);

            // Assert
         Assert.IsFalse(result, $"{value} should not be prime");
     }


       // Test case for If Else function
        [TestCase("rahul", "077", "Invalid Credential")]
        [TestCase("", "", "Please provide input first")]
        [TestCase("Rahul", "007", "Hello Mr Stark")]
        [Test]
        public void CheckInput_Method_TestCase (string Name, string Code, string message)
        {
            // Act
            string result = _services.CheckInput(Name, Code);


            // Assert
            Assert.AreEqual(message, result);
        }


        // Test Case of Sitch Case
        
        [TestCase(1,"This is case 1" )]
        [TestCase(2, "This is case 2")]
        [TestCase(3, "This is case 3")]
        [TestCase(4, "This is case 4")]
        [Test]

        public void SwitchCase_Method(int value, string outputMessage) 
        {
            // Act
            var result = _services.SwitchCase(value);

            // Assert
            Assert.AreEqual(outputMessage, result);


        
        }


        // Test case stringlen function
        [TestCase("Rahul", 5)]
        public void StringLen_Check(string word, int leng)
        {
            var result = _services.StringLength(word);
            Assert.AreEqual(leng, result);
        }
        


        // List Element count For-Each Test Case

        [Test]
        public void NumerOfElementInList()
        {
            var ListValue = new List<string> { "Rahul","Shayam", "Tony","Steve Rogers", "Bruce Banner" };
            int result = _services.ListPrint(ListValue);
            Assert.AreEqual(5, result);

        }

    
       // for loop average test case
        [TestCase(4,2)]
        [TestCase(3,2)]
        [TestCase(9,2)]
        [TestCase(0,0)]
        [Test]
       public void AverageFunction(int value , int message)
        {
            int result = _services.Averagae(value);
            Assert.AreEqual(message,result);
            
        }

        // Exception of Average Method
        [Test]
        public void Exception_Of_AverageFunction()
        {
            var ex = Assert.Throws<NullReferenceException>(()=>_services.Averagae(-1));
            Assert.AreEqual("Less Than 1", ex.Message);
        }


        //Async Test Case
        [Test]
        public async Task Average_Of_4_Method_Test()
        {
            var result = await _services.Avergae_Of_4_Number(1, 2, 3, 4);
            Assert.AreEqual(2, result);
        }

        [Test(ExpectedResult =3)]
        public async Task<int> Async_Average_exm2()
        {
            return await _services.Avergae_Of_4_Number(5, 4, 3, 2);
        }



        // Test CAse of while loop for even number
        [TestCase(4,"Even Number")]
        [TestCase(3, "Not An Even Number")]
        [TestCase(2, "Even Number")]
        [TestCase(8, "Even Number")]
        [TestCase(1, "Not An Even Number")]
        [Test]
        public void While_Even(int num, string mssg)
        {
            var result = _services.Even_number_while_loop(num);
            Assert.AreEqual(mssg, result);

        }

        // Try And Catch for Zero Divide
        [Test]
        public void Zero_Divide()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => _services.DivideByZero(0, 5));
            Assert.AreEqual("Cannot Divide by Zero",ex.Message);
        }

 }
}