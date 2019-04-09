using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to reduce:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The reduced number is {0}", DigitalRoot(number));
        }
        static public long DigitalRoot(long n)
        {
            // Your awesome code here!
            if (n % 10 == n)
                return n;
            else
            {
                long answer = (n % 10) + DigitalRoot((n - n % 10) / 10);
                if (answer > 9)
                    return DigitalRoot(answer);
                else
                    return answer;
            }
        }
    }
}
