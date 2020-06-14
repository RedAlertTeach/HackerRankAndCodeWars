public static List<Integer> findPrimeFactors(int n)
	{
		List<Integer> results = new ArrayList<Integer> ();
		
		// see how many times 2 is a factor
		 while (n % 2 == 0)  
		 {  
		        results.add(2);
		        n = n/2;  
		 }
		 
		 // now check all other odd possibilities up to square root of n
		 for (int i = 3; i <= Math.sqrt(n); i = i + 2)  
		    {  
		        // While i divides n, add i to the list and divide n  
		        while (n % i == 0)  
		        {  
		            results.add(i);
		            n = n/i;  
		        }  
		    }  
		
		 // if n is still greater than 2 then it is prime and is the only factor
		 if (n > 2)  
			 results.add(n);
		
		
		
		return results;
		
	}
