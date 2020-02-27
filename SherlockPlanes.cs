using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockPlanes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] points = new int[4][];
            points[0] = new int[] { 1, 2, 0 };
            points[1] = new int[] { 2, 3, 0 };
            points[2] = new int[] { 4, 0, 0 };
            points[3] = new int[] { 0, 0, 0 };
            Console.WriteLine(solve(points));
            Console.ReadLine();


        }
        static string solve(int[][] points)
        {
            bool[] results = { true, true, true };

            for (int i = 0; i < points[0].Length; i++) // column stays constant
            {
                for (int j = 1; j < points.Length; j++) // row moves
                {
                    if (points[j][i] != points[j - 1][i])
                    {
                        results[i] = false;
                        break;
                    }

                }

            }



            if (results[0] || results[1] || results[2])
                return "YES";
            else
                return "NO";

        }
    }
}
