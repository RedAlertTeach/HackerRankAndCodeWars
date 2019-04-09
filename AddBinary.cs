using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to add and convert to binary:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the two numbers in decimal is {0}, and the sum in binary is {1}", num1 + num2, ConvertToBinary(num1 + num2));
        }

        static public string ConvertToBinary(int number)
        {
            if (number == 0)
                return "0";
            else if (number == 1)
                return "1";
            else
            {
                if (number % 2 == 0)
                    return ConvertToBinary(number / 2) + "0";
                else
                    return ConvertToBinary(number / 2) + "1";
            }
        }
    }
}
