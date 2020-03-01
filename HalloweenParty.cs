using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {1856378,
525494,
4137970,
952497,
3477282,
4915727,
4743036,
7987985,
6440878,
1523303};
            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("Pieces: {0}", solve(input[i]));
            }
            Console.ReadLine();
        }
        static long solve(int k)
        {
            long mult = k / 2;
            int rem = k % 2;
            return (mult + rem) * mult;
        //    return (k / 2 + k % 2) * (k / 2);


        }
    }
}
