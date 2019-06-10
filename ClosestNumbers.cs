using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] numbers = new int[] { 3, 5, 2, 4, 1 };
            int[] numbers = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };
            int[] closest = FindClosestNumbers(numbers);
            foreach (int n in closest)
            {
                Console.WriteLine("{0}", n);
        
            }
            Console.ReadLine();
        }
        static public int[] FindClosestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            int minDiff = int.MaxValue;
            for (int i = 1; i < numbers.Length; i++)
            {
                int diff = numbers[i] - numbers[i - 1];
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            List<int> pairs = new List<int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i-1] == minDiff)
                {
                    pairs.Add(numbers[i - 1]);
                    pairs.Add(numbers[i]);
                }
            }
            return pairs.ToArray();
        }
    }
}
