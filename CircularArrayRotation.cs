using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3 };
            int k = 2;
            int[] queries = new int[] { 0, 1, 2, };
            int[] results = RotateAndQuery(numbers, k, queries);
            foreach (int i in results)
                Console.WriteLine("{0}", i);
            Console.ReadLine();
        }
        static public int[] RotateAndQuery(int[] original, int N, int[] queries)
        {
            N = N % original.Length;
            var firstHalf = original.Take(original.Length - N);
            var secondHalf = original.Skip(original.Length - N);
            var together = secondHalf.Concat(firstHalf);
            int[] rotated = together.ToArray();
            int[] results = new int[queries.Length];
            int index = 0;
            foreach (int i in queries)
            {
                results[index++] = rotated[i];
            }
            return results;
        }
    }
}
