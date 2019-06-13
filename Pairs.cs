using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\pairs.txt";
            string readText = File.ReadAllText(fileName);
            string[] numberStrings = readText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);

            //   int[] numbers = new int[] { 1, 5, 3, 4, 2 };

            int pairs = FindPairs(numbers, 204619);
            Console.WriteLine("The number of pairs is {0}.", pairs);
            Console.ReadLine();
        }
        static public int FindPairs(int[] numbers, int diff)
        {
            Console.WriteLine("The length of the array is {0}", numbers.Length);
            Array.Sort(numbers);
            Console.WriteLine("Sort completed...");

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i + 1; (j <= i + diff) && (j < numbers.Length); j++)
                {
                    if (numbers[j] - numbers[i] > diff)
                    {
                        break;
                    }
                    else if (numbers[j] - numbers[i] == diff)
                        count++;
                }

            }
            return count;
        }
    }
}
