using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int CalculateFibonacci(int number)
        {
            if (number == 0) return 0;
            else if (number == 1) return 1;
            else
                return (CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2));

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateFibonacci(n));
        }
    }
}
