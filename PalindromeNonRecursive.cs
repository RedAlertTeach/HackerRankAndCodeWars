using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeNonRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMirror = 0;
            int numPivot = 0;
            int numNot = 0;

            Console.WriteLine("Enter a word or phrase.  Enter QQQ to quit.");

            string phrase = Console.ReadLine();
            while (phrase != "QQQ")
            {

                phrase = phrase.StripPunctuation().ToLower().Replace(" ", "");

                // Console.WriteLine("The string stripped of punctuation and spaces is {0}", phrase);

                char[] charArray = phrase.ToCharArray();

                Array.Reverse(charArray);

                string reversed = new string(charArray);

                // Console.WriteLine("The reversed string is {0}", reversed);

                if (phrase.Equals(reversed))
                {
                    if ((phrase.Length % 2) == 0)
                    {
                        Console.WriteLine("The phrase is a MIRROR palindrome");
                        numMirror++;
                    }
                    else
                    {
                        Console.WriteLine("The phrase is a PIVOT palindrome");
                        numPivot++;
                    }
                }
                else
                {
                    Console.WriteLine("The phrase is NOT a palindrome");
                    numNot++;
                }

                Console.WriteLine("Enter a word or phrase.  Enter QQQ to quit.");

                phrase = Console.ReadLine();
            }
            Console.WriteLine("Number of MIRROR palindromes entered was {0}.", numMirror); 
            Console.WriteLine("Number of PIVOT palindromes entered was {0}.", numPivot);
            Console.WriteLine("Number of NON palindromes entered was {0}.", numNot);

        }
        
    }
    public static class StringExtension
        {
            public static string StripPunctuation(this string s)
            {
                var sb = new StringBuilder();
                foreach (char c in s)
                {
                    if (!char.IsPunctuation(c))
                        sb.Append(c);
                }
                return sb.ToString();
            }
        }
}
