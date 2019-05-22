using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] instructions = new int[] { 1 };
            int n = 1;
            Console.WriteLine("The values of the counters after the instructions are:");
            int[] counters = CalcCounters(n, instructions);
            foreach (int c in counters)
                Console.Write("{0} ", c);
            Console.ReadLine();
        }
        static public int[] CalcCounters(int n, int[] instructions)
        {
            int[] counters = new int[n];
            int largest = 0;
            for (int i = 0; i < instructions.Length; i++)
            {
                if (instructions[i] == n + 1)
                    SetAllToMax(largest, counters);
                else
                {
                    counters[instructions[i]-1]++;
                    if (counters[instructions[i] - 1] > largest)
                        largest = counters[instructions[i] - 1];
                }
            }






            return counters;
        }
        static public void SetAllToMax(int largest, int[] counters)
        {
            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = largest;
            }
            return;
        }
    }
}
