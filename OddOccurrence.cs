using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 9, 3, 7, 9 };
            var groups = from n in nums
                         orderby n
                         group n by n into g
                         where g.Count() == 1
                         select g;
        
            foreach (var o in groups)
               Console.WriteLine("The odd man is {0}", o.Key);
        }
    }
}
