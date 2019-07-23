using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10000; i++)
            {
                int num = 1;
                Console.WriteLine("The shortest number of steps to reach {0} is {1}", i, Shortest(i));
            }
            Console.ReadLine();
        }
        static int Shortest(int num)
        {
            int count = 0;
            while (num > 1)
            {
                int remainder = num % 2;
                while (remainder == 0)
                {
                    num = num / 2;
                    count++;
                    remainder = num % 2;
                }
                if (num > 1)
                {
                    num--;
                    count++;
                }
            }
            return count;
        }
    }
}
