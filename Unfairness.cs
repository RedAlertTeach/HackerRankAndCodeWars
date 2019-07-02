using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unfairness
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 4, 7, 2 };
            int k = 2;

            int minimum = CalculateMin(numbers, k);
            Console.WriteLine("The minimum unfairness is {0}", minimum);
            Console.ReadLine();
        }
        static public int CalculateMin(int[] numbers, int k)
        {
            int min = Int32.MaxValue;
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length - k + 1; i++)
            {
              
                int diff = 0;
                diff = numbers[i + k - 1] - numbers[i];
                if (diff < min)
                    min = diff;
            }
            if (min == Int32.MaxValue)
                min = 0;
            return min;
        }
    }
}
