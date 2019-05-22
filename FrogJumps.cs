using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 80;
            int D = 35;
            Console.WriteLine("The frog needs to make {0} jumps.", CalculateJumps(X, Y, D));
        }
        static int CalculateJumps(int X, int Y, int D)
        {
            if (X == Y)
                return 0;
            else if (D > Y - X)
                return 1;
            else if (((Y - X) % D) > 0)
                return ((Y - X) / D + 1);
            else return (Y - X) / D;
        }
    }
}
