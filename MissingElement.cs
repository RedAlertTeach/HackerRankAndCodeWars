using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2,3,1,5, 7, 9, 4, 8 };
            Console.WriteLine("The missing number is {0}", FindMissing(numbers));

        }
        static int FindMissing (int[] numbers)
        {
            var newList = from n in numbers
                          orderby n
                          select n;
            var prev = 0;
            foreach (var n in newList)
            {
                if (n != prev + 1)
                    return n - 1;
                prev = n;
            }
            return 0;
        }
    }
}
