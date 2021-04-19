using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceClass
    {
        // Prime number checking Method
        public bool IsPrime(int candidate)
        {


            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }




        // Method to Check Input Credential by If-Else
        public string CheckInput(string Name, string Code)
        {

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Code))
            {
                return "Please provide input first";
            }

            else
            {
                if (Name == "Rahul" && Code == "007")
                {
                    return "Hello Mr Stark";
                }

                return "Invalid Credential";
            }

        }


        // Switch Case Method
        public string SwitchCase(int value)
        {
            string message = "";

            switch (value)
            {
                case 1:
                    message = "This is case 1";
                    break;

                case 2:
                    message = "This is case 2";
                    break;

                case 3:
                    message = "This is case 3";
                    break;

                case 4:
                    message = "This is case 4";
                    break;
            }
            return message;
        }


        // Dummy example
        public int StringLength(string inputString)
        {
            int l = inputString.Length;
            return l;
        }



        // For-Each loop Method

        public int ListPrint(List<string> ListValue)
        {
            int elementCount = 0;

            foreach (string element in ListValue)
            {
                elementCount++;
            }

            return elementCount;
        }

        // For loop
        public int Averagae(int n)
        {
            if (n >= 0)
            {
                int multi = 0;
                for (int i = 1; i <= n; i++)
                {
                    multi = (n + (n - 1) + (n - 2) + (n - n)) / n;

                }
                return multi;
            }

            else
            {

                throw new NullReferenceException("Less Than 1");
            }
        }


        // Async Method
        public async Task<int> Avergae_Of_4_Number(int val1, int val2, int val3, int val4)
        {
            return (val1 + val2 + val3 + val4) / 4;

        }

        // Even Number with While Loop

        public string Even_number_while_loop(int n)
        {
            bool options = true;
            while (options)
            {

                if (n % 2 == 0)
                {
                    return "Even Number";
                }
                break;
                

            }
            options = false;
                return "Not An Even Number";


        }



        // Try And Catch
        public int DivideByZero(int val1, int val2)
        {
            try
            {
                return val2 / val1;
            }
            catch(Exception ex)
            {
                throw new DivideByZeroException("Cannot Divide by Zero");
            }
        }


    }
}
