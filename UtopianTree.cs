using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int utopianTree(int n) {
        // Complete this function
        
        if (n == 0)
            return 1;
        else if (n % 2 == 1)
            return 2 * (utopianTree(n - 1));
        else 
            return 1 + (utopianTree(n - 1));
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int result = utopianTree(n);
            Console.WriteLine(result);
        }
    }
}
