using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        if ((n-k) < k)
           shiftArrayRight(a,n-k);
        else
           shiftArrayLeft(a, k);
        for (int i = 0; i < a.Length; i++)
            {
            Console.Write(a[i] + " ");
        }
    }
    static void shiftArrayLeft(int[] inputArray, int numberOfShifts)
        {
        for (int i = 1; i <= numberOfShifts; i++)
            {
            shiftOneLeft(inputArray);
        }
        }
    static void shiftOneLeft(int[] arrayToShift)
        {
        int firstElement = arrayToShift[0];
        for (int i = 0; i < arrayToShift.Length - 1; i++)
            {
            arrayToShift[i] = arrayToShift[i+1];
        }
        arrayToShift[arrayToShift.Length - 1] = firstElement;
    }
    static void shiftArrayRight(int[] inputArray, int numberOfShifts)
        {
        for (int i = 1; i <= numberOfShifts; i++)
            {
            shiftOneRight(inputArray);
        }
        }
    static void shiftOneRight(int[] arrayToShift)
        {
        int lastElement = arrayToShift[arrayToShift.Length - 1];
        for (int i = arrayToShift.Length - 2; i >= 0; i--)
            {
            arrayToShift[i+1] = arrayToShift[i];
        }
        arrayToShift[0] = lastElement;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokensIn = Console.ReadLine().Split(' ');
            int itemsInArray = Convert.ToInt32(tokensIn[0]);
            int numberToShift = Convert.ToInt32(tokensIn[1]);
            string[] dataAsString = Console.ReadLine().Split(' ');
            int[] dataAsInt = Array.ConvertAll(dataAsString, Int32.Parse);
            for (int i = numberToShift; i < itemsInArray; i++)
            {
                Console.Write("{0} ", dataAsInt[i]);
            }
            for (int j = 0; j < numberToShift; j++)
            {
                Console.Write("{0} ", dataAsInt[j]);
            }
        }
    }
}

