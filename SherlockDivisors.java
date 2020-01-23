import java.io.FileReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class SherlockDivisors {

    public static void main(String[] args) {

	/*int test = 388958238;
	int even = findDivisors(test);
	System.out.println("The number of even divisors for " + test + " is " + even);
	 */for (int i = 1; i <= 100; i++)
	 {

	     int even = findDivisors(i);
	     System.out.println("The number of even divisors for " + i + " is " + even);
	 }
	 /*try
	{
	    FileReader reader = new FileReader("h:/downloads/divisors.txt");
	    Scanner in = new Scanner(reader);

	    while (in.hasNextLine())
	    {
		int test = Integer.parseInt(in.nextLine());

		int even = findDivisors(test);
		System.out.println("The number of even divisors for " + test + " is " + even);
	    }
	    in.close();

	}
	catch (Exception e)
	{
           System.out.println("Exception caught.");
	}
	finally
	{
	}    */


    }
    static public int findDivisors(int test)
    {

	if (test % 2 != 0)
	    return 0;
	else if (test == 2)
	    return 1;
	else

	{
	    ArrayList<Integer> divisors = primeFactors(test);
	    int expCount = 1;
	    int expProduct = 1;
	    int oddExpProduct = 1;

	    int i = 0;

	    while (i < (divisors.size() - 1))
	    {
		while (i < (divisors.size() - 1) && divisors.get(i+1) == divisors.get(i))
		{
		    expCount++;
		    i++;
		}
		expProduct *= (expCount + 1);

		if (divisors.get(i) != 2)
		    oddExpProduct *= (expCount + 1);

		expCount = 1;
		i++;
	    }

	    if (divisors.get(divisors.size() - 1) != divisors.get(divisors.size() - 2))
	    {
		expProduct *= 2;
		oddExpProduct *= 2;
	    }

	    return expProduct - oddExpProduct;
	}
    }
    public static ArrayList<Integer> primeFactors(int n) 
    { 
	// Find the number of 2s that divide n 
	ArrayList<Integer> factors = new ArrayList<Integer>();
	while (n % 2 == 0) 
	{ 
	    factors.add(2);
	    n /= 2; 
	} 

	// n must be odd at this point.  So we can 
	// skip one element (Note i = i +2) 
	for (int i = 3; i <= Math.sqrt(n); i += 2) 
	{ 
	    // While i divides n, save i and divide n 
	    while (n % i == 0) 
	    { 
		factors.add(i);
		n /= i; 
	    } 
	} 

	// Handle the case when n is a prime number greater than 2 
	if (n > 2) 
	    factors.add(n); 

	return factors;
    } 
}
