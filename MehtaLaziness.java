import java.io.File;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class MehtaLaziness {

	public static void main(String[] args) {
		
		//  int N = 335908; // 1/11
	/*	int N = 36;
		  String result = getEvenSquareProb(N);
		  System.out.println(result + " for the number " + N);
	*/	 

		try { 
			File file = new File("c:/users/loakley/downloads/mehtalargebatch.txt");
			Scanner sc = new Scanner(file);

			while (sc.hasNextLine())
			{ 
				int n = Integer.parseInt(sc.nextLine()); 
				String  result = getEvenSquareProb(n);
				System.out.println(result + " for the number "  + n);

			}
		} catch (Exception e) 
		{ 
			System.out.println(e.getMessage());
		}

	}
	public static String getEvenSquareProb(int N)
	{
		String result = "0";
		if (N == 2 || N % 2 != 0)
			return result;
		List<Integer> divisors = new ArrayList<Integer> ();
		divisors.add(1);
		divisors.add(2);
		divisors.add(N/2);
	//	int times = 0;
		int top = N/2;
		for (int i = 3; i < top; i++)
		{
			if (N % i == 0)
			{
				if (!divisors.contains(i))
					divisors.add(i);
				if (!divisors.contains(N/i))
					divisors.add(N/i);
			    top = N/i;
				
			}
			//times++;
		}
		//	System.out.println("The number of divisors of " + N + " is " + divisors.size());
        //    System.out.println("The loop ran " + times + " times.");
		int count = 0;

	//	System.out.println("The divisors are:");
	//	Collections.sort(divisors);
		for (Integer n : divisors)
		{
		//	System.out.println(n);
			if (n % 2 == 0)
			{
				int root = (int)Math.sqrt(n);
				if (root * root == n)
				{
					//	System.out.println(n + " is an even perfect square divisor.");
					count++;
				}
			}
		}
		//	System.out.println("The number of even perfect square divisors is " + count);
		if (count == 0)
			return result;
		else
		{
			int size = divisors.size();
			int gcd = findGCD (count, size);
			

			result = "" + count/gcd + "/" + size/gcd;
		}




		return result;
	}

	public static int findGCD(int a, int b)
	{
		if (a == 0)
			return b;
		else if (b == 0)
			return a;
		else
			return findGCD(b, a % b);
	}
}
