import java.io.*;
import java.util.*;
interface PerformOperation {
 boolean check(int a);
}
class MyMath {
 public static boolean checker(PerformOperation p, int num) {
  return p.check(num);
 }
 PerformOperation isOdd()
 {
     return new PerformOperation() {
        public boolean check(int num) {
            return num % 2 == 1 ? true : false;
        }
     };
 }
 PerformOperation isPalindrome()
 {
     return new PerformOperation() {
        public boolean check(int num) {
            int sum = 0;
            int temp = num;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum = sum * 10 + digit;
                temp /= 10;
            }
            
            if (sum == num)
               return true;
            else
               return false;
        }
     };
 }
 PerformOperation isPrime()
 {
     return new PerformOperation() {
        public boolean check(int number) {
            java.util.function.IntPredicate isDivisible = index -> number % index == 0;
            return number > 1 && java.util.stream.IntStream.range(2, number - 1).noneMatch(isDivisible);
        }
     };
 }
}
   // Write your code here

public class Solution {

 public static void main(String[] args) throws IOException {
  MyMath ob = new MyMath();
  BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
  int T = Integer.parseInt(br.readLine());
  PerformOperation op;
  boolean ret = false;
  String ans = null;
  while (T--> 0) {
   String s = br.readLine().trim();
   StringTokenizer st = new StringTokenizer(s);
   int ch = Integer.parseInt(st.nextToken());
   int num = Integer.parseInt(st.nextToken());
   if (ch == 1) {
    op = ob.isOdd();
    ret = ob.checker(op, num);
    ans = (ret) ? "ODD" : "EVEN";
   } else if (ch == 2) {
    op = ob.isPrime();
    ret = ob.checker(op, num);
    ans = (ret) ? "PRIME" : "COMPOSITE";
   } else if (ch == 3) {
    op = ob.isPalindrome();
    ret = ob.checker(op, num);
    ans = (ret) ? "PALINDROME" : "NOT PALINDROME";

   }
   System.out.println(ans);
  }
 }
}
