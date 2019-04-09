using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterMidnight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of minutes.");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The day/time is {0}", DetermineDayTime(minutes));

        }

        static public string DetermineDayTime(int minutes)
        {
            bool negative = minutes < 0 ? true : false;

            minutes = Math.Abs(minutes);




            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = minutes / 1440;
            int adjustedDay = day % 7;
            string dayOfWeek = days[negative ? (6 - adjustedDay) : adjustedDay];

            int minutesIntoDay = negative ? (1440 - minutes % 1440) : minutes % 1440;
            int hour = minutesIntoDay / 60;
            int minutesIntoHour = minutesIntoDay % 60;

            return String.Format("{0} {1:D2}:{2:D2}", dayOfWeek, hour, minutesIntoHour);




        }
    }
}
