using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){
        // Complete this function

        
        if (s.Length > 1)
        {
            bool stringReduced = false;
            while (!stringReduced)
            {
            int length = s.Length;
            string finalString = "";
            int currentIndex = 0;
            while (currentIndex < length)
            {
            int nextIndex = currentIndex + 1;
            int duplicateLetterCount = 1;
            string currentCharacter = s[currentIndex].ToString();
            string nextCharacter = "";
            if (nextIndex < length)
                nextCharacter = s[nextIndex].ToString();
            while (currentCharacter == nextCharacter)
            {
                stringReduced = true;
                duplicateLetterCount++;
                currentIndex++;
                nextIndex++;
                if (nextIndex < length)
                   nextCharacter = s[nextIndex].ToString();
                else
                   nextCharacter = "";
            }
            if ((duplicateLetterCount % 2) == 1) // the number of duplicate letters is odd so we need one
                finalString += currentCharacter;
            currentIndex = nextIndex;    
            }
                s = finalString;
                if (stringReduced)
                {
                    
                    stringReduced = false;
                }
                else
                    break;
                
            }
           return s;
        }
        else
           return s;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        if (result == "")
            Console.WriteLine("Empty String");
        else
            Console.WriteLine(result);
    }
}

