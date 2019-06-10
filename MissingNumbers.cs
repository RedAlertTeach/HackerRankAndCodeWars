using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] originalList = new int[] { 7, 2, 5, 4, 6, 3, 5, 3 };
            //  int[] modifiedList = new int[] { 7, 2, 5, 3, 5, 3 };
            int[] originalList = new int[] { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] modifiedList = new int[] { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };

            int[] difference = FindTheDifference(originalList, modifiedList);
            foreach (int n in difference)
            {
                Console.WriteLine("{0}", n);
            }
            Console.ReadLine();
        }
        static public int[] FindTheDifference(int[] original, int[] modified)
        {
            int[] originalCounted = new int[10000];
            int[] modCounted = new int[10000];
            int[] difference = new int[10000];
            foreach (int n in original)
            {
                originalCounted[n]++;
            }
            foreach (int n in modified)
            {
                modCounted[n]++;
            }
            int count = 0;
            for (int i = 0; i < modCounted.Length; i++)
            {
                if (originalCounted[i] != modCounted[i])
                {
                    difference[i] = i;
                    count++;
                }
            }
            int[] final = new int[count];
            int counter = 0;
            foreach (int n in difference)
            {
                if (n != 0)
                    final[counter++] = n;
            }
            return final;
        }
    }
}
