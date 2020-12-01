using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "a";
            long length = 1000000000000;
            Console.WriteLine("The number of 'a's is {0}", countAs(input, length));
            Console.ReadLine();
        }

        static long countAs(string input, long length)
        {
            int number = 0;
            int remaining = 0;

            long multiplier = length / input.Length;

            long left = length % input.Length;

            for (int i = 0; i < input.Length; i++)

                if (input[i] == 'a')
                {
                    number++;
                    if (i < left)
                        remaining++;
                }

            
            return number * multiplier + remaining;
        }
    }
}
