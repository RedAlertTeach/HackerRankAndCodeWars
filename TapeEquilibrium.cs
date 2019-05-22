using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tape = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("The minimal different is {0}.", MinimalDifference(tape));
            Console.ReadLine();

        }
        static int MinimalDifference(int[] tape)
        {
            // brute force
            int minimal = int.MaxValue;

            for (int i = 0; i < tape.Length; i++)
            {
                int firstHalf = (from num in tape
                                 select num).Take(i).Sum();
                int secondHalf = (from num in tape
                                  select num).Skip(i).Sum();
                int difference = Math.Abs(firstHalf - secondHalf);
                if (difference < minimal)
                    minimal = difference;
            }
            return minimal;
        }
    }
}
