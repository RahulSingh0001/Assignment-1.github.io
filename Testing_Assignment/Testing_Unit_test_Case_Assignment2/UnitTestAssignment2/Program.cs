using System;

namespace UnitTestAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Multiple case senario of string
            string sample = "rAhUl samPLE NaME";
            Console.WriteLine("**********************");
            Console.WriteLine("Converted \"" + sample + "\" according to the Case i.e UpperCase to Lower Case and vice-versa : " + sample.CaseOfConverter());
            
           


            
            //Title Case Convert
            sample = "Rahul singh demo";
            Console.WriteLine("************************");
            Console.WriteLine("Converted \"" + sample + "\" into Titlecase : " + sample.TitleCaseConverter());
            
            
            //Case to check if string is Lower or not (For Positive Test Senario)
            sample = "rahulSingh";
            Console.WriteLine("************************");
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + sample + "\" : " + sample.CaseIsLower());

            //Case to check if string is Lower or not (For Negative Test Senario)
            sample = "rahulsingh";
            Console.WriteLine("************************");
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + sample + "\" : " + sample.CaseIsLower());
            
            
            //Case for capitalization of string
            sample = "rahul Singh";
            Console.WriteLine("*************************");
            Console.WriteLine("Converted \"" + sample + "\" into Capitalize : " + sample.CapitalizationOfString());


            //Case to check if string is Upper or not (For Positive Test Senario)
            sample = "RAHULSINGH";
            Console.WriteLine("*************************");
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + sample + "\" : " + sample.CaseIsUpper());


            //Case to check if string is Upper or not (For Negative Test Senario)
            sample = "rahulSingh";
            Console.WriteLine("*************************");
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + sample + "\" : " + sample.CaseIsUpper());


           //Case to count words in string
            sample = "rahul singh";
            Console.WriteLine("*************************");
            Console.WriteLine("No of word in \"" + sample + "\" : " + sample.CountingOfWords());
            
            
            //Case for removing last character of string
            sample = "Rahul Singh";
            Console.WriteLine("*************************");
            Console.WriteLine("After removing last char from string \"" + sample + "\" : " + sample.CharacterRemoval());
            
            //Case to check whether the given input string is valid or not
            string num = "333A";
            Console.WriteLine("*******************************");
            if (num.ValidationOfNumber() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");





            //Case to convert string into number
            Console.WriteLine("********************************************");
            Console.WriteLine("123".IntegerConverter());
            

        }
    }
}
