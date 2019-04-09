using System;

using System.Linq;
using System.Text;


namespace DisemVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to DisemVowel:");
            string input = Console.ReadLine();
            Console.WriteLine("The DisemVoweled string is {0}", RemoveVowels(input));

        }
        static public string RemoveVowels(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (!("AEIOUaeiou".Contains(c)))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
