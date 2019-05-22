using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number for which to compute the binary gap:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The binary gap is {0}.", Solution.solution(number));

        }
    }
    class Solution
    {
        static public int solution(int n)
        {
            string binaryRep = ConvertToBinary(n);

            // look at the binary string in reverse to eliminate leading (trailing) zeroes
            int counter = binaryRep.Length - 1;
            int maxGap = 0;
            while (counter > 0)
            {
                // skip leading zeroes
                while (binaryRep[counter] == '0' && counter > 0)
                    counter--;
                while (binaryRep[counter] == '1' && counter > 0)
                    counter--;
                int newGap = 0;
                while (binaryRep[counter] == '0' && counter > 0)
                {
                    counter--;
                    newGap++;
                }
                if (newGap > maxGap)
                    maxGap = newGap;
            }
            //while (counter < binaryRep.Length - 1)
            //{
            //    while ((binaryRep[counter] == '1') && (counter < binaryRep.Length - 1))
            //        counter++;
            //    int newGap = 0;
            //    while ((binaryRep[counter] =='0') && (counter < binaryRep.Length - 1))
            //    {
            //        counter++;
            //        newGap++;
            //    }
            //    if (newGap > maxGap)
            //        maxGap = newGap;
            //}
            return maxGap;

        }
        static public string ConvertToBinary(int n)
        {
            if (n == 0)
                return "";
            else if (n % 2 == 0)
                return ConvertToBinary(n / 2) + "0";
            else
                return ConvertToBinary(n / 2) + "1";
        }
    }
}
