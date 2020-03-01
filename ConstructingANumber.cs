using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructingANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4 };
            Console.WriteLine("{0}", canConstruct(numbers));
            Console.ReadLine();
        }
        static string canConstruct(int[] a)
        {
            string result = "No";
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += addDigits(a[i]);

            }
            if (sum % 3 == 0)
                result = "Yes";
            return result;

        }
        static int addDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
