using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Steve Clements 1/13/2018. Find the first non-repeating character in a string
namespace firstNonRepeatCharInString
{
    public class nonRepeatCharStr
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a word/string:");
                string testString = Console.ReadLine();
                string firstNonRepeatCharInStr = firstNonRepeatChar(testString);

                Console.WriteLine("The first non-repeating character is: " + firstNonRepeatCharInStr);
            }
        }

        public static string firstNonRepeatChar(string testStr)
        {
            bool match = false;
            for (int i = 0; i < testStr.Length; i++)
            {
                match = false;
                //get the char at testStr[0]
                string character = testStr[i].ToString();
                for (int j = i + 1; j < testStr.Length; j++)
                {
                    //compare the char at testStr[i] to the char at testStr[i + 1]
                    //if they are the same, replace that character with an empty string
                    //until the only thing left is the character which doesn't have a duplicate
                    if (character == testStr[j].ToString())
                    {
                        match = true;
                        testStr = testStr.Replace(character, "");
                        i = -1;
                        break;
                    }
                }
                if (match == false)
                    return character;
            }
            Console.WriteLine("There are no non-repeating characters");
            return null;
        }
       
    }
}
