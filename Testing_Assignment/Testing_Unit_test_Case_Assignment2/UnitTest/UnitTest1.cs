using System;
using UnitTestAssignment2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        //Question 1 and 2
        //Test Case to Convert Upper case string to lower case and vice versa
        [Fact]
        public void ConvertTestCase()
        {
            string sample = "rAhUl";
            string result = sample.CaseOfConverter();
            
        }
        //End of ConvertTestCase



        //Question 3
        //Test Case to Convert string into Title
        [Fact]
        public void TitleCaseTest()
        {
            string sample = "Rahul singh demo";
            string result = sample.TitleCaseConverter();
            
        }
        //End of TitleCaseTest Function



        //Question 4
        //Test Case to check string is in lower case or not
        [Fact]
        public void LowerCaseTest()
        {
            string sample = "rahul singh";
            bool result = sample.CaseIsLower();
            
        }
        //End of LowerCaseTest



        //Question 5
        //Test Case for capitalization of string
        [Fact]
        public void StringCapitalizer()
        {
            string sample = "rahul singh";
            string result = sample.CapitalizationOfString();
            
        }
        //End of StringCapitalizer function


        //Question 6
        //Test Case to check string is in lower case or not
        [Fact]
        public void UpperCaseTest()
        {
            string sample = "Rahul Singh";
            bool result = sample.CaseIsUpper();

        }
        //End of LowerCaseTest

        //Question 7
        [Fact]
        public void NumberValidationCase()
        {
            string sample = "333";
            bool result = sample.ValidationOfNumber();
            
        }
        //End of NumberValidationCase function



        //Question 8
        //Case to Remove last Character of string
        [Fact]
        public void RemoveCharacterCase()
        {
            string sample = "Rahul";
            string result = sample.CharacterRemoval();

        }
        //End of RemoveCharacterCase



        //Question 9
        //Test case to count the word in string name 'sample'
        [Fact]
        public void CountTheWords()
        {
            string sample = "rahul singh";
            int result = sample.CountingOfWords();
           
        }
        //End of word counting test case here 



        //Question 10
        //String to integer converter
        [Fact]
        public void IntConverter()
        {
            string sample = "454";
            int? result = sample.IntegerConverter();

        }
        //End of IntConverter function

















    }
}
