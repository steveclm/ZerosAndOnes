using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Steve Clements 1/4/2018 Palindrome Tester. BayShore Solutions Developer Code Test
namespace Palindrome
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {    
            //having this while(true) here keeps the console open to accept multiple entries by the user
            while(true)
            {
                Console.WriteLine("Enter a positive integer to check if is a palindrome:");
                string testInteger = Console.ReadLine();

                //regex checks to see if input is anything other than an integer, ie: negative numbers & non-digits
                bool isAPosInteger = Regex.IsMatch(testInteger, @"^\d+$");

                //call IsItAPalindrome() with input as a string
                bool isItPalBool = IsItAPalindrome(testInteger);

                if(!isAPosInteger)
                    Console.WriteLine(testInteger + " is NOT a valid positive integer. Please re-enter a positive integer.");
               
                else if (isItPalBool)
                    Console.WriteLine(testInteger + " IS a palindrome!");

                else if (!isItPalBool)
                    Console.WriteLine(testInteger + " IS NOT a palindrome!");

                //add a space between entries
                Console.WriteLine();
            }            
        }

        public static bool IsItAPalindrome(string pal)
        {
            //have to convert the string to a Char Array to call Reverse()
            char[] palToCharArrayReversed = pal.ToCharArray();

            Array.Reverse(palToCharArrayReversed);

            //have to turn it back into a string to call CompareTo()
            string reversedBackToString = new string(palToCharArrayReversed);
            int compareToResult = pal.CompareTo(reversedBackToString);

            //CompareTo() only returns 0 if those 2 strings are the same
            if (compareToResult != 0)
                return false;
            else 
                return true;
        }
    }
}
