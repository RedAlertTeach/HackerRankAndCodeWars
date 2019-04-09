using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    using System;

    class MergeSortAlgorithm
    {
        public static long MergeSort(int[] input, int low, int high)
        {
            if (low == high)
                return 0;
            // else
            //{
            long inversionCount = 0;
                int middle = (low / 2) + (high / 2);
                inversionCount += MergeSort(input, low, middle);
                inversionCount += MergeSort(input, middle + 1, high);
                inversionCount += Merge(input, low, middle, high);
                return inversionCount;
           // }
        }

        public static long MergeSort(int[] input)
        {
            return MergeSort(input, 0, input.Length - 1);
        }

        private static long Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;
            long inversionCount = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] > input[right])
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    inversionCount += ((middle - left) + 1);
                }
                else
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
            return inversionCount;
        }

        public static string PrintArray(int[] input)
        {
            string result = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result = result + input[i] + " ";
            }
            if (input.Length == 0)
            {
                result = "Array is empty.";
                return result;
            }
            else
            {
                return result;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDataSets = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfDataSets; i++)
            {
                int itemsInDataSet = Convert.ToInt32(Console.ReadLine());
                string[] dataAsString = Console.ReadLine().Split(' ');
                int[] dataAsInt = Array.ConvertAll(dataAsString, Int32.Parse);
                Console.WriteLine(MergeSortAlgorithm.MergeSort(dataAsInt).ToString());
                Console.WriteLine(MergeSortAlgorithm.PrintArray(dataAsInt));
                
            }
        }
    }
}
