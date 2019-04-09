using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int result = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            result ^= a[i];
        }
        Console.WriteLine(result);
    }
}
