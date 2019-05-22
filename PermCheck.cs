using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 1, 1, 1 };
            if (DeterminePerm(numbers) == 1)
                Console.WriteLine("The array IS a permutation.");
            else
                Console.WriteLine("The array IS NOT a permutation.");
            Console.ReadLine();

        }
        static public int DeterminePerm(int[] numbers)
        {
            int max = numbers.Max();
            int number = numbers.Count();
            int[] counts = new int[max > number ? max : number];
            for (int i = 0; i < numbers.Count(); i++)
            {
                counts[numbers[i] - 1]++;
            }
            for (int i = 0; i < counts.Count(); i++)
            {
                if (counts[i] == 0)
                    return 0;
            }
            return 1;
            

        }
    }
}
