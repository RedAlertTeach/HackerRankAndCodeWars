using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpOnClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clouds = { 0, 0, 0, 1, 0, 0 };

            Console.WriteLine("The minimum number of jumps is {0}", countJumps(clouds));
            Console.ReadLine();
        }

        static int countJumps(int[] clouds)
        {
            int sum = 0;
            int i = 0;
            for (i = 0; i < clouds.Length - 2; )
            {
                if (clouds[i + 2] == 0)
                              
                    i += 2;
                else
                    i++;
                sum++;
            }
            if (i == clouds.Length - 2)
                sum++;
            return sum;
        }
    }
}
