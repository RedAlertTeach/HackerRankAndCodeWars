using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 5, 3, 4 };
            minimumBribes(array);
            Console.ReadLine();
        }
        static void minimumBribes(int[] arr)
        {
            bubbleSort(arr);
        }
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            int totalSwaps = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                int swaps = 1;
                int swapValue = 0;
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    
                    int prevSwapValue = 0;

                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        prevSwapValue = swapValue;

                        swapValue = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapValue;
                        totalSwaps++;
                        swapped = true;
                        if (prevSwapValue == swapValue)
                        {
                            swaps++;
                            if (swaps > 2)
                            {
                                Console.WriteLine("Too chaotic");
                                return;
                            }
                        }
                        else
                        {
                           swaps = 1;
                        }
                        
                        
                    }
                }
                if (swapped == false)
                    break;
            }
            Console.WriteLine("{0}", totalSwaps);
        }
    }
}
