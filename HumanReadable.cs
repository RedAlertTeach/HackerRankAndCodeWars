using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumanReadable
{
    class Program
    {
        static int secondsPerYear = 3600 * 24 * 365;
        static int secondsPerDay = 3600 * 24;
        static int secondsPerHour = 3600;
        static int secondsPerMinute = 60;




        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of seconds to be converted:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The seconds converted to human readable format is {0}", ConvertSeconds(seconds));
            Console.ReadLine();
        }
        static string ConvertSeconds(int seconds)
        {
            if (seconds == 0)
                return "now";
            else
            {
                List<string> components = new List<string>();

                string formatted = "";

                string years = FindYears(seconds);
                if (years != "")
                    components.Add(years);

                string days = FindDays(seconds % secondsPerYear);
                if (days != "")
                    components.Add(days);

                string hours = FindHours(seconds % secondsPerDay);
                if (hours != "")
                    components.Add(hours);

                string minutes = FindMinutes(seconds % secondsPerHour);
                if (minutes != "")
                    components.Add(minutes);

                string second = FindSeconds(seconds % secondsPerYear % secondsPerDay % secondsPerHour % secondsPerMinute);
                if (second != "")
                    components.Add(second);

                if (components.Count == 1)
                    formatted += components[0];
                else if (components.Count == 2)
                    formatted += components[0] + " and " + components[1];
                else
                {
                    for (int i = 0; i < components.Count - 2; i++)
                    {
                        formatted += components[i] + ", ";
                    }
                    formatted += components[components.Count - 2] + " and " + components[components.Count - 1];
                }
                return formatted;
            }
        }
        static string FindYears(int seconds)
        {
            string yearString = "";
            
            int years = seconds / secondsPerYear;
            if (years > 0)
            {
                yearString += Convert.ToString(years) + " year";
                if (years > 1)
                    yearString += "s";
            }
            return yearString;
           
            
        }
        static string FindDays(int seconds)
        {
            string dayString = "";

            int days = seconds / secondsPerDay;
            if (days > 0)
            {
                dayString += Convert.ToString(days) + " day";
                if (days > 1)
                    dayString += "s";
            }
            return dayString;


        }
        static string FindHours(int seconds)
        {
            string hourString = "";

            int hours = seconds / secondsPerHour;
            if (hours > 0)
            {
                hourString += Convert.ToString(hours) + " hour";
                if (hours > 1)
                    hourString += "s";
               
            }
            return hourString;


        }
        static string FindMinutes(int seconds)
        {
            string minuteString = "";

            int minutes = seconds / secondsPerMinute;
            if (minutes > 0)
            {
                minuteString += Convert.ToString(minutes) + " minute";
                if (minutes > 1)
                    minuteString += "s";
                
            }
            return minuteString;


        }
        static string FindSeconds(int seconds)
        {
            string secondString = "";

            if (seconds > 0)
            {
                secondString += Convert.ToString(seconds) + " second";
                if (seconds > 1)
                    secondString += "s";
            }

            
            return secondString;


        }
    }
}
