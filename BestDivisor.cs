using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 198;
            List<int> divisors = findDivisors(test);
            int best = findBest(divisors);
            Console.WriteLine(best);
          //  Console.WriteLine("The best divisor for {0} is {1}", test, best);
            Console.ReadLine();
        }
        static public List<int> findDivisors(int test)
        {
            List<int> results = new List<int>();
            results.Add(1);
            for (int i = 2; i <= test / 2; i++)
            {
                if (test % i == 0)
                    results.Add(i);
            }
            results.Add(test);

            return results;
        }

        static public int findBest(List<int> divisors)
        {
            int result = 1;
            int best = 1;
            foreach (int d in divisors)
            {
                int sum = findSum(d);
                if (sum > result)
                {
                    result = sum;
                    best = d;
                }
            }
            return best;
        }

        static private int findSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }
            return sum;
        }
    }
}
