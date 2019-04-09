using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int countingValleys(int n, string s) {
        // Complete this function
        int valleyCount = 0;
        int level = 0;
        int prevLevel = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'U')
                level++;
            if (s[i] == 'D')
                level--;
            if ((level == 0) && (prevLevel == -1))
            {
                valleyCount++;
            }
            prevLevel = level;
        }
        return valleyCount;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
