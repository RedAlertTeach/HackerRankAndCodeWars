using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] steps = new int[3][];
            steps[0] = new int[] { 1000000, 1000000 };
            steps[1] = new int[] { 1000000, 1000000 };
            steps[2] = new int[] { 1000000, 1000000 };
            Console.WriteLine("The number of largest is {0}", solve(steps));
            Console.ReadLine();
        }
        static long solve(int[][] steps)
        {
            long smallestX = Int32.MaxValue; 
            long smallestY = Int32.MaxValue;
            for (int i = 0; i < steps.GetLength(0); i++)
            {
                if (steps[i][0] < smallestX)
                    smallestX = steps[i][0];
                if (steps[i][1] < smallestY)
                    smallestY = steps[i][1];
            }
            return smallestX * smallestY;
    }
    }
}
