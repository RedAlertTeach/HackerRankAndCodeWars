import java.io.*;
import java.math.*;
import java.text.*;
import java.util.*;
import java.util.regex.*;

public class Solution {

    /*
     * Complete the handshake function below.
     */
    static int handshake(int n) {
        /*
         * Write your code here.
         */
         int sum = 0;
         for (int i = 1; i < n; i++)
         {
             sum += i;
         }
         return sum;

    }