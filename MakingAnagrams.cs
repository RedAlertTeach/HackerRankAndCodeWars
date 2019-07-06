using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "cde";
            int difference = CalculateAnagramDifference(s1, s2);
            Console.WriteLine("The number of letters that must be removed is {0}", difference);
            Console.ReadLine();
        }
        static int CalculateAnagramDifference(string s1, string s2)
        {
            int count = 0;
            int[] letters1 = new int[26];
            int[] letters2 = new int[26];
            foreach (char c in s1)
            {
                letters1[c - 'a']++;
            }
            foreach (char c in s2)
            {
                letters2[c - 'a']++;
            }
            for (int i = 0; i < letters1.Length; i++)
            {
                count += Math.Abs(letters1[i] - letters2[i]);
            }
            return count;
        }
    }
}
