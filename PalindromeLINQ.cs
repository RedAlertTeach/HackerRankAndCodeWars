using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase:");
            string phrase = Console.ReadLine();

            

            

            phrase = new string ((from c in phrase
                            where Char.IsPunctuation(c) == false && Char.IsWhiteSpace(c) == false
                            select c).ToArray()).ToLower();

            string revPhrase = new string(phrase.Reverse().ToArray());

            if (phrase == revPhrase)
                if (phrase.Length % 2 == 0)
                {
                    Console.WriteLine("The string is a MIRRORED palindrome");
                }
                else
                {
                    Console.WriteLine("The string is a PIVOT palindrome");
                }
            else
                Console.WriteLine("The string is NOT a palindrome");

        }
    }
}
