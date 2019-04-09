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
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int[] countsA = new int[26];
            int[] countsB = new int[26];
            char presentCharacter;
            for (int i = 0; i < a.Length; i++)
            {
                presentCharacter = a[i];
                countsA[presentCharacter - 'a']++;
            }
            for (int j = 0; j < b.Length; j++)
            {
                presentCharacter = b[j];
                countsB[presentCharacter - 'a']++;
            }
            int difference = 0;
            for (int k = 0; k < countsA.Length; k++)
            {
                difference += Math.Abs(countsA[k] - countsB[k]);
            }
            Console.WriteLine(difference);
        }
    }
}
