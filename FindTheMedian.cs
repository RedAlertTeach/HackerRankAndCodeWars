using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 73, 56, 1, 1, 1, 98, 98, 56, 98 };

            int result = FindTheMedian(numbers);

            Console.Write("The median is {0}", result);
            Console.ReadLine();
        }
        static public int FindTheMedian(int[] numbers)
        {
          /*  Array.Sort(numbers);
            return numbers[(numbers.Length - 1) / 2]; */
            int[] results = new int[200001];
            foreach (int n in numbers)
            {

                results[n+(results.Length/2)]++;
            }

            int middle = (numbers.Length - 1) / 2;
            int count = 0;
            int i = 0;
            do
            {
                count += results[i];
                i++;
            }
            while (count < (middle + 1) && i < results.Length);
            return (i - 1) - (results.Length/2); 
        }
    }
}
