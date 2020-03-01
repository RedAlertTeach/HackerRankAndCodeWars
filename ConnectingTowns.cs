using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingTowns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] routes = { 756, 547, 807, 283, 355, 712, 161, 816, 773, 41, 380, 4, 469, 598, 282, 162, 843, 972, 404, 737, 741, 538, 698, 733, 730, 343, 594, 944, 776, 289, 127, 91, 956, 917, 363, 586, 699, 941, 270, 587 };
            Console.WriteLine("The number of routes is {0}", connectingTowns(41, routes));
            Console.ReadLine();
        }
        static int connectingTowns(int n, int[] routes)
        {
            long result = 1;
            for (int i = 0; i < routes.Length; i++)
            {
                result *= routes[i];
                result %= 1234567;
            }
            return (int) result;

        }
    }
}
