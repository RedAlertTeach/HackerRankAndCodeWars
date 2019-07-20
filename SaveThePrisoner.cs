using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisoners
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\prisoners.txt";
            string readText = File.ReadAllText(fileName);
            string[] numberStrings = readText.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
            int number = numbers[0];
            for (int i = 0; i < number; i++)
            {
                int n = numbers[3*i + 1];
                int m = numbers[3*i + 2];
                int s = numbers[3*i + 3];
                Console.WriteLine("Test case number {0}: {1}", i + 1, Warn(n, m, s));
            }
            Console.ReadLine();
        }
        static int Warn(int n, int m, int s)
        {
            int result = 0;
            if (m >= n)
               result = (m % n) + s - 1;
            else
                result = s + m - 1;
            if (result > n)
                result = result - n;
            else if (result == 0)
                result = n;
            return result;
        }
    }
    

}
