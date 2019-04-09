using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void printArray(int[] myArray)
    {
        for (int l = 0; l < myArray.Length; l++)
        {
            Console.Write("{0} ", myArray[l]);
        }
        Console.WriteLine();
    }
    static void calculateWeights(string s, int[] weights)
    {
        int k = 26;
        int j = 0;
        int sameCharCount = 1;
        while (j < s.Length)
        {
            int currentWeight = s[j] - 'a' + 1;
            weights[currentWeight - 1] = currentWeight;
            char current = s[j];
            char next = j + 1 >= s.Length?  (char) 0 : s[j+1];
            if (current == next)
            {
                sameCharCount++;
                weights[k] = currentWeight * sameCharCount;
                k++;
            }
            else
            {
                sameCharCount = 1;
            }
       //     printArray(weights);
            j++;
        }
        
    }
    static void Main(String[] args) {
        string s = Console.ReadLine();
        int[] weights = new int[s.Length*2+26];
        calculateWeights(s, weights);
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++){
            int x = Convert.ToInt32(Console.ReadLine());
            if (weights.Contains(x))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            // your code goes here
        }
    }
}
