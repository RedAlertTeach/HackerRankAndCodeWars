using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIckingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 2, 1, 2 };
            int maxNum = LongestArray(numbers);
            Console.WriteLine("The length of the maximum subarray is {0}", maxNum);
            Console.ReadLine();
        }
        static int LongestArray(int[] numbers)
        {
            int[] counted = new int[100];
            foreach (int i in numbers)
            {
                counted[i]++;
            }
            int largest = 0;
            for (int i = 1; i < counted.Length; i++)
            {
                int difference = counted[i] + counted[i - 1];
                if (difference > largest)
                    largest = difference;
            }
            return largest;
        }
    }
}
