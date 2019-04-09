using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            string[] inputStrings = Console.ReadLine().Split(' ');
            int[] inputInts = Array.ConvertAll(inputStrings, Int32.Parse);
            int totalNumberOfSwaps = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < numberOfItems - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (inputInts[j] > inputInts[j + 1])
                    {
                        int temp = inputInts[j];
                        inputInts[j] = inputInts[j + 1];
                        inputInts[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }
                totalNumberOfSwaps += numberOfSwaps;
                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.", totalNumberOfSwaps);
            Console.WriteLine("First Element: {0}", inputInts[0]);
            Console.WriteLine("Last Element: {0}", inputInts[numberOfItems - 1]);
        }
    }
}
