using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int beautifulDays(int i, int j, int k) {
        // Complete this function
        int beautifulNumbers = 0;
        for (int test = i; test <= j; test++)
        {
            string orig = test.ToString();
            string reversed = new string(orig.ToCharArray().Reverse().ToArray());
       //     reversed = reversed.Replace("0","");
            if ((Math.Abs(test - Convert.ToInt64(reversed)) % k) == 0)
                beautifulNumbers++;
        }
        return beautifulNumbers;
    }

    static void Main(String[] args) {
        string[] tokens_i = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(tokens_i[0]);
        int j = Convert.ToInt32(tokens_i[1]);
        int k = Convert.ToInt32(tokens_i[2]);
        int result = beautifulDays(i, j, k);
        Console.WriteLine(result);
    }
}
