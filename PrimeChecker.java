import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.lang.reflect.*;
import static java.lang.System.in;  // Static import is a feature introduced in the Java programming language
                                    // that allows members (fields and methods) which have been scoped within 
                                    // their container class as public static , to be used in Java code without 
                                    // specifying the class in which the field has been defined.

class Prime {
    public void checkPrime (int ... a)
    {
       for (int number : a)
       {
          if (isPrime(number))
              System.out.print(number + " ");
       }
       System.out.println();
    }
    public boolean isPrime(int n)
    {
        if (n == 0 || n == 1)
           return false;
        int m = n/2;
        boolean prime = true;
        for (int i = 2; i <= m; i++)
        {
           if (n % i == 0)
           {
               prime = false;
               break;
           }
        }
        return prime;
    }
   
}

public class Solution {

	public static void main(String[] args) {
		try{
		BufferedReader br=new BufferedReader(new InputStreamReader(in));
		int n1=Integer.parseInt(br.readLine());
		int n2=Integer.parseInt(br.readLine());
		int n3=Integer.parseInt(br.readLine());
		int n4=Integer.parseInt(br.readLine());
		int n5=Integer.parseInt(br.readLine());
		Prime ob=new Prime();
		ob.checkPrime(n1);
		ob.checkPrime(n1,n2);
		ob.checkPrime(n1,n2,n3);
		ob.checkPrime(n1,n2,n3,n4,n5);	
		Method[] methods=Prime.class.getDeclaredMethods();
		Set<String> set=new HashSet<>();
		boolean overload=false;
		for(int i=0;i<methods.length;i++)
		{
			if(set.contains(methods[i].getName()))
			{
				overload=true;
				break;
			}
			set.add(methods[i].getName());
			
		}
		if(overload)
		{
			throw new Exception("Overloading not allowed");
		}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
	
}

