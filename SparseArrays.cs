using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" };

            string[] queries = new string[] { "abcde", "sdaklfj", "asdjf", "na", "basdn" };

            int[] results = matchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", results));
        }
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            Array.Sort(strings);
            int[] counts = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int occur = 0;
                int counter = 0;
                while ((String.Compare(strings[counter], queries[i]) < 0) && (counter < strings.Length))
                    counter++;
                if (counter < strings.Length)
                {
                    while (counter < strings.Length && (String.Compare(strings[counter], queries[i]) == 0))
                    {
                        counter++;
                        occur++;
                    }
                    counts[i] = occur;
                }

            }
            return counts;

        }
    }
   
}
