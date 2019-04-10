using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your time:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your converted time is {0}", ConvertToHRT(seconds));

        }

        static string ConvertToHRT(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = seconds % 3600 / 60;
            int secs = seconds % 3600 % 60;

            return String.Format("{0:d2}:{1:d2}:{2:d2}", hours, minutes, secs);
        }
    }
}
