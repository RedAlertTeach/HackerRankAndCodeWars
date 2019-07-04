using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTI
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "cdefghmnopqrstuvw";
            string result = GameOfThrones(phrase);
            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
        }
        static string GameOfThrones(string phrase)
        {
            string result = "YES";
            int[] letterCounts = new int[26];
            foreach (char c in phrase)
            {
                letterCounts[c - 'a']++;
            }
            int numberOfOdds = 0;
            foreach (int count in letterCounts)
            {
                if (count % 2 != 0)
                    numberOfOdds++;
                if (numberOfOdds > 1)
                {
                    result = "NO";
                    break;
                }
            }
            return result;
        }
    }
}
