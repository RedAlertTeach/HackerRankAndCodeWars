using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static bool doTheyMatch(string left, string right)
        {
        if ((left == null) || (right == null))
            return false;
        else if (((left == "{") && (right == "}")) || ((left == "[") && (right == "]")) || ((left == "(") && (right == ")")))
            return true;
        else
            return false;
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string expression = Console.ReadLine();
            string leftBrackets = "{[(";
            string rightBrackets = "}])";
            if ((expression.Length % 2) == 1)
                Console.WriteLine("NO");
            else
                {
                Stack<string> symbols = new Stack<string>();
                bool matchedBrackets = true;
                for (int i = 0; i < expression.Length; i++)
                    {
                    string bracket = expression[i].ToString();
                    if (leftBrackets.Contains(bracket))
                        {
                        symbols.Push(bracket);
                    } 
                    else if (rightBrackets.Contains(bracket))
                        {
                        if (symbols.Count > 0)
                            {
                            string match = symbols.Peek();
                            if (doTheyMatch(match, bracket))
                                symbols.Pop();
                            else
                                {
                                matchedBrackets = false;
                                break;
                            }
                        }
                        else
                            {
                            matchedBrackets = false;
                            break;
                        }
                    }
                    else
                        {
                        matchedBrackets = false;
                        break;
                    }
                }
                if (matchedBrackets)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        } 
    }
}
/* Alternative solution from discussion: */
/*static string matchBrackets(char[] chars){
            Stack s = new Stack();
            foreach(char c in chars){                
                    if(c== '{') s.Push('}');
                    else if(c==  '(') s.Push(')');
                    else if(c==  '[') s.Push(']');
                    else
                    {
                        if (s.Count == 0 || c != (char)s.Peek()) 
                            return "NO";
                        s.Pop(); 
                    }                
            }
            return s.Count == 0 ? "YES": "NO";            
}*/
