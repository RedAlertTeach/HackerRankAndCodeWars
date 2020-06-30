import java.util.*;
class Solution{
	
	public static void main(String []argh)
	{
		Scanner sc = new Scanner(System.in);
		
		while (sc.hasNext()) {
			String input=sc.next();
            //Complete the code
            Stack stack = new Stack();
            boolean balanced = true;
            for (int i = 0; i < input.length(); i++)
            {
                char next = input.charAt(i);
                if ("{([".contains(String.valueOf(next)))
                {
                    stack.push(next);
                }
                else if ("})]".contains(String.valueOf(next)))
                {
                   if (stack.empty())
                   {
                       balanced = false;
                       break;
                   }
                   else  // see if we have a match
                   {
                       char top = (char) stack.pop();
                       if (!((top == '{' && next == '}') ||
                            (top == '(' && next == ')') ||
                            (top == '[' && next == ']')))
                            {
                          balanced = false;
                          break;
                            }

                   }
                }
                else
                {
                   balanced = false;
                   break;
                }
            }
            if (balanced && stack.empty())
               System.out.println("true");
            else
               System.out.println("false");
		}
		
	}
}



