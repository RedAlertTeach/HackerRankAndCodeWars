import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int numberOfItems = Integer.parseInt(sc.nextLine());
        int[] numbers = new int[numberOfItems];
        int count = 0;
        while (sc.hasNext())
        {
           numbers[count] = Integer.parseInt(sc.next());
           count++;
        }
        int subs = calcSubArrays(numbers);
       System.out.println(subs);
    }
    public static int calcSubArrays(int[] numbers)
    {
        int result = 0;
        // count the number of single negative sub-arrays (number of negatives in the array)
        for (int i = 0; i < numbers.length; i++)
        {
            if (numbers[i] < 0)
                result++;
        }
        // count the number of negative sub-arrays length 2 to length of the entire array
        for (int j = 2; j <= numbers.length; j++)
        {
            for (int k = 0; k <= numbers.length - j; k++)
            {
                int sum = 0;  // intermediate sub-array sum
                for (int l = k; l < j + k; l++)
                {
                    sum += numbers[l];
                }
                if (sum < 0)
                    result++;
            }
        }
        return result;
    }

}