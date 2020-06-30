import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);

       int n = sc.nextInt();
       int m = sc.nextInt();
       BitSet b1 = new BitSet(n);
       BitSet b2 = new BitSet(n);

       for (int i = 1; i <= m; i++)
       {
           String op = sc.next();
           int op1 = sc.nextInt();
           int op2 = sc.nextInt();
           if (op.equals("AND"))
           {
               if (op1 == 1)
                  b1.and(b2);
               else
                  b2.and(b1);
           }
           else if (op.equals("OR"))
           {
               if (op1 == 1)
                  b1.or(b2);
               else
                  b2.or(b1);
           }
           else if (op.equals("XOR"))
           {
               if (op1 == 1)
                  b1.xor(b2);
               else
                  b2.xor(b1);
           }
            else if (op.equals("FLIP"))
           {
               if (op1 == 1)
                  b1.flip(op2);
               else
                  b2.flip(op2);
           }
            else if (op.equals("SET"))
           {
               if (op1 == 1)
                  b1.set(op2);
               else
                  b2.set(op2);
           }
           System.out.println(b1.cardinality() + " " + b2.cardinality());
       }
    }
}