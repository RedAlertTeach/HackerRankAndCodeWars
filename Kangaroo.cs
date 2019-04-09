using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Complete this function
        if ((x2 > x1) && (v2 > v1))
            return ("NO");
        else
        {
            int jumps = 0;
            bool meet = false;
            while (!meet)
            {
                int rooPosition1 = x1 + (v1 * jumps);
                int rooPosition2 = x2 + (v2 * jumps);
                if (rooPosition1 == rooPosition2)
                {
                    meet = true;
                    break;
                    
                }
                if (((x1 > x2) && (rooPosition2 > rooPosition1)) || ((x2 > x1) && (rooPosition1 > rooPosition2)))
                {
                    break;
                }
                jumps++;
                
            }
            if (meet)
                return ("YES");
            else
                return ("NO");
        }
    }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
