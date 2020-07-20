import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;


public class Solution{
	public static void main(String[] args){
		
		Scanner in = new Scanner(System.in);
		int testCases = Integer.parseInt(in.nextLine());
        String WITH_DELIMITER = "((?<=%1$s)|(?=%1$s))";

		while(testCases>0){
			String line = in.nextLine();
			
            String[] html = line.split(String.format(WITH_DELIMITER, "<|>"));
           Stack<String> tags = new Stack<String>();
            String content = "";
            boolean match = false;
            int writeCount = 0;
         //   boolean openingTag = false;
            for (int j = 0; j < html.length; j++)
            {
                if (html[j].equals("<"))
                {
                    j++;
                    String tag = "";
                    if (j < html.length)
                       tag = html[j];
                    else
                        break;
                    char c = tag.charAt(0);
                    if (c != '/')  // the tag is an opening tag
                    {
                        tags.push(tag); // put the tag on the stack
                    //    System.out.println("The opening tag is " + tag);
                    //    openingTag = true;
                        content = "";
                    }
                    else  // the tag is a closing tag
                    {
                        String closingTag = "/" + tags.pop();
                    //    openingTag = false;
                        if (tag.equals(closingTag))
                        {
                    //        System.out.println("The closing tag is " + closingTag);
                            if (content != "")
                            {
                               System.out.println(content);
                               match = true;
                               writeCount++;
                            }
                            content = "";
                        }
                        else
                        {
                            match = false;
                            content = "";
                        }
                        
                            
                        
                    }
                    j++; // increment j past closing ">"

                }
                else
                {
                    // the string was not a tag so it is content
                    if (openingTag)
                       content = html[j];
                    else
                        content = "";

                }
                
            }
            if (!match && (writeCount == 0))
                
                System.out.println("None");


			testCases--;
		}
	}
}



