using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int p){
        // Complete this function
         if ((p % 2) == 0)
            p++;
         if ((n % 2) == 0)
            n++;
        return Math.Min((p-1)/2,(n-p)/2);

    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}