using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PrimeNumbers
{
    class Program
    {
        static bool isPrime(int number, int factor)
        {
            if (factor <= 9)
            {
                if ((number != factor) && ((number % factor) == 0))
                {
                    return false;
                }
                else
                {
                    return isPrime(number, factor + 1);
                }
            }
            else
                return true;
        }
        static bool isPerfectSquare(int number)
        {
            int root = (int)Math.Sqrt(number);
            if ((root * root) == number)
                return true;
            else
                return false;
        }
        static void calculatePrimesLessThan100(List<int> primes)
        {
            for (int i = 1; i <=100; i++)
            {
                if (isPrime(i, 2))
                    primes.Add(i);
            }

        }
        static void calculatePrimesLessThan1000(List<int> primes)
        {
            for (int i = 101; i <= 1000; i++)
            {
                if ((!hasPrimeFactor(i, primes)) && (!isPerfectSquare(i)))
            
                   primes.Add(i);
            }

        }
        
        static bool hasPrimeFactor(int number, List<int> primes)
        {
            foreach (int prime in primes)
            {
                if ((number % prime) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(String[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            List<int> primesLessThan1000 = new List<int>();
            calculatePrimesLessThan100(primesLessThan1000);
            calculatePrimesLessThan1000(primesLessThan1000);
            for (int a0 = 0; a0 < p; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (isPerfectSquare(n))
                    Console.WriteLine("Not prime");
                else if ((n != 1) && (isPrime(n, 2)))
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not prime");
            }
        }
    }

}P