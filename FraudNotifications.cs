using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraudNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] expenditures = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
            //int lookBack = 5;
            //Console.WriteLine("The number of notifications is {0}", CalculateNotifications(expenditures, lookBack));
            //Console.ReadLine();
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\fraud.txt";
            string readText = File.ReadAllText(fileName);
            string[] numberStrings = readText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
            Console.WriteLine("The number of notifications is {0}", CalculateNotifications(numbers, 10000));
            Console.ReadLine();
        }
        static public int CalculateNotifications(int[] spend, int lookBack)
        {

            if (spend.Length < (lookBack + 1))
            {
                return 0;
            }
            else
            {
                int notifyCount = 0;
                int[] lastDaysArray = new int[lookBack];

                Array.Copy(spend, lastDaysArray, lookBack);

                // Build the counting sort array
                int[] results = new int[201];
                foreach (int n in lastDaysArray)
                {

                    results[n]++;
                }

                for (int i = lookBack; i < spend.Length; i++)
                {
                
                    double median = FindTheMedian(results, lastDaysArray.Length);

                    if (spend[i] >= (2 * median))
                    {
                        notifyCount++;

                    }

                    // update the counting sort array
                    
                    results[spend[i]]++;
                    results[spend[i - lookBack]]--;


                }
                return notifyCount;
            }
        }
        static public double FindTheMedian(int[] results, int length)
        {
            int middle = length / 2;

            // odd length - median is the middle number
            if (length % 2 == 1)
            {
                int count = 0;
                for (int i = 0; i < results.Length; i++)
                {
                    count += results[i];

                    if (count > middle)
                    {
                        return i;
                    }
                }
            }
            // even length - median is the average of the two middle numbers
            else
            {
                int count = 0;
                int leftOfMiddle = -1;
                int rightOfMiddle = -1;
                for (int i = 0; i < results.Length; i++)
                {
                    count += results[i];

                    if (count == middle)
                    {
                        leftOfMiddle = i;
                    }
                    else if (count > middle)
                    {
                        if (leftOfMiddle < 0)
                            leftOfMiddle = i;
                        rightOfMiddle = i;

                        return (leftOfMiddle + rightOfMiddle) / 2.0;
                    }
                }
            }
            return 0;
        }
    }
}