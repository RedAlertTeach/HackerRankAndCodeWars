using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static int MAX_INT = 1000001;
        static void Main(string[] args)
        {
             int[] numbers = new int[] { 1, 3, 6, 4, 1, 2, 1000000, -1000000, 0 };
           // int[] numbers = new int[] { -1, -1000 };
            Console.WriteLine("The smallest missing integer is {0}.", FindMissing(numbers));
            Console.ReadLine();
        }
        static public int FindMissing(int[] numbers)
        {
            int[] counts = new int[MAX_INT];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    counts[numbers[i]]++;
            }
            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] == 0)
                    return i;
            }
            return 1;
        }
    }
}
