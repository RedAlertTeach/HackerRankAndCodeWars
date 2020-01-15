using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the findPoint function below.
     */
    static int[] findPoint(int px, int py, int qx, int qy) {
        /*
         * Write your code here.
         */
         int[] newPoint = new int[2];
         newPoint[0] = (qx - px) + qx;
         newPoint[1] = (qy - py) + qy;
         return newPoint; 

    }