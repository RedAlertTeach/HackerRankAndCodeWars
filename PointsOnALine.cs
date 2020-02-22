using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> xS = new List<int>();
        List<int> yS = new List<int>();
        for (int nItr = 0; nItr < n; nItr++) {
            string[] xy = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xy[0]);
            xS.Add(x);

            int y = Convert.ToInt32(xy[1]);
            yS.Add(y);
        }
        int prevX = xS.ElementAt(0);
        string resultX = "YES";
        foreach (int i in xS)
        {
            if (i != prevX)
            {
               resultX = "NO";
               break;
            }
            prevX = i;
        }
        int prevY = yS.ElementAt(0);
        string resultY = "YES";
        foreach (int i in yS)
        {
            if (i != prevY)
            {
               resultY = "NO";
               break;
            }
            prevY = i;
        }
        if (resultX == "YES" || resultY == "YES")
           Console.WriteLine("YES");
        else
           Console.WriteLine("NO");
    }
}
