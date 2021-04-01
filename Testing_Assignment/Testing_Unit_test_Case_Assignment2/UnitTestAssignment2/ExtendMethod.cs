using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UnitTestAssignment2
{
    public static class ExtendMethod
    {

        //Question 1 and 2
        //Creating Method for multiple case of string converter
        public static string CaseOfConverter(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] cArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    cArray[i] = char.IsUpper(cArray[i]) ? char.ToLower(cArray[i]) : char.ToUpper(cArray[i]);
                }
                return new string(cArray);
            }
            return inputString;
        }
        // End of CaseOfConverter



        //Question 3
        //Method to convert string into title case(except for words that are entirely in uppercase, which are considered to be acronyms)
        public static string TitleCaseConverter(this string inputString)
        {
            if (inputString.Length > 0)
            {
                string result = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(inputString.ToLower());
                return result;
            }
            return inputString;
        }
        //End of Method TitleCaseConverter



        //Question 4
        //Method to Check if all the characters from given input string are in lower case or not.
        public static bool CaseIsLower(this string inputString)
        {
            int count = 0;
            int len = inputString.Length;
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (char.IsLower(charArray[i]) || char.IsWhiteSpace(charArray[i]))
                    {
                        count++;
                    }
                }
                if ( count == len)
                    return true;
            }
            return false;
        }
        //End of method CaseIsLower.



        //Question 5
        //Method to return a capitalized version of given input string i.e. make the first character have upper case and the rest lower case
        public static string CapitalizationOfString(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                for (int i = 1; i < inputString.Length; i++)
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                return new string(charArray);
            }
            return inputString;
        }
        //End of CapitalizationOfString method




        //Question 6
        ////Method to Check if all the characters from given input string are in Upper case or not.
        public static bool CaseIsUpper(this string inputString)
        {
            int count = 0;
            int len = inputString.Length;
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (char.IsUpper(charArray[i]) || char.IsWhiteSpace(charArray[i]))
                    {
                        count++;
                    }
                }
                if (count == len)
                    return true;
            }
            return false;
        }
        //End of CaseIsUpper method


        //Question 7
        //Function to identify whether given input string can be converted to a valid numeric value or not
        public static bool ValidationOfNumber(this string inputString)
        {
            if (inputString.Length > 0)
            {
                int number;
                return int.TryParse(inputString, out number);
            }
            return false;
        }
        //End of ValidationOfNumber method


        //Question 8
        //function to remove the last character from given the string
        public static string CharacterRemoval(this string inputString)
        {
            if (inputString.Length > 0)
            {
                return inputString.Substring(0, inputString.Length - 1);
            }
            return inputString;
        }
        //End of CharacterRemoval function



        //Question 9
        //Using Extension Method for counting of words
        public static int CountingOfWords(this string inputString)
        {
            if (inputString.Length > 0)
            {
                string[] words = inputString.Split(' ');
                return words.Length;
            }
            return 0;
        }
        //End of CountingOfWords Method


        //Question 10
        //Convert an input string to integer.
        public static int IntegerConverter(this string inputString)
        {
            int x = 0;
            if (inputString.Length > 0)
            {
                Int32.TryParse(inputString, out x);
            }
            return x;
        }
        //End of IntegerConverter Method



















    }
}
