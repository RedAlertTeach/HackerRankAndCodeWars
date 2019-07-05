using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hi";
            string s2 = "world";
            string result = DetermineCommon(s1, s2);
            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
        }
        static string DetermineCommon(string s1, string s2)
        {
            string result = "NO";

            int[] letterCounts1 = new int[26];
            int[] letterCounts2 = new int[26];
            foreach (char c in s1)
            {
                letterCounts1[c - 'a']++;
            }
            foreach (char c in s2)
            {
                letterCounts2[c - 'a']++;
            }
            for (int i = 0; i < letterCounts1.Length; i++)
            {
                if (letterCounts1[i] > 0 && letterCounts2[i] > 0)
                {
                    result = "YES";
                    break;
                }
            }

            return result;
        }
    }
}
