using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasant
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            int exp = 17;
            Console.WriteLine("{0} raised to {1} is {2} and should be {3}", num, exp, peasantMe(num, exp), Math.Pow(num, exp));
            Console.ReadLine();

        }
        static long peasantMe(int num, int exp)
        {
            long prod = num;
            int originalExp = exp;
            int calculatedExp = 1;
            while (exp >= 2)
            {
                prod *= prod;
                exp /= 2;
                calculatedExp *= 2;
            }
            while (calculatedExp < originalExp)
            {
                prod *= num;
                calculatedExp++;
            }
            return prod;
        }
    }
}
