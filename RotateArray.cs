using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            Console.WriteLine("Enter how much you want to shift the array.");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] shifted = ShiftArray(original, number);

            Console.WriteLine("The original array is:");
            foreach (int n in original)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            Console.WriteLine("The shifted array is:");
            foreach (int n in shifted)
            {
                Console.Write("{0} ", n);
            }
        }
        static public int[] ShiftArray(int[] original,int N)
        {
            N = N % original.Length;
            var firstHalf = original.Take(original.Length - N);
            var secondHalf = original.Skip(original.Length - N);
            var together = secondHalf.Concat(firstHalf);
            return together.ToArray();
        }
    }
}
