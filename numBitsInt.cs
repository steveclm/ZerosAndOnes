using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Steve Clements 1/13/2018. Determines the number of 1 bits in an integer
namespace numOfOneBitsInAnInt
{
    public class numBitsInt
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer:");
                int testInteger = Int32.Parse(Console.ReadLine());
                int numOfOneBits = countNumBitsInInt(testInteger);

                Console.WriteLine(testInteger + " has " + numOfOneBits + " \'1\' bits in it!");
            }
        }

        static int countNumBitsInInt(int n)
        {
            int numOfOnes = 0;
            while (n > 0)
            {
                //Binary AND Operator '&' copies a bit to the result if it exists in both operands. ie: (A & B) = 12, which is 0000 1100
                numOfOnes += n & 1;
                //Right shift AND assignment operator
                n >>= 1;
            }
            return numOfOnes;
        }
    }
}
