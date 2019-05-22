using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leaves = new int[] { 2, 1 };
            int distance = 2;
            if (DetermineTime(distance, leaves) == -1)
                Console.WriteLine("The frog can never cross the river.");
            else
               Console.WriteLine("The earliest time the frog will cross the river is {0}.", DetermineTime(distance, leaves));
            Console.ReadLine();
        }
        static public int DetermineTime(int X, int[] leaves)
        {
            int[] counts = new int[X];
            for (int i = 0; i < leaves.Length; i++)
            {
                counts[leaves[i] - 1]++;
                if (IsArrayNonZero(counts))
                    return i;
            }
            return -1;
        }
        static public bool IsArrayNonZero(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                    return false;
            }
            return true;
        }
    }
}
