
public class LexicogCompare {

	public static void main(String[] args) {
       String test = "welcometojava";
       int k = 3;
       
       String extremes = findSmallestAndLargest(test, k);
       
       System.out.println(extremes);
       
       
       
	}
	
	public static String findSmallestAndLargest(String test, int k)
	{
		
		
		
		String smallest = test.substring(0, k);
		String largest = test.substring(0, k);
		for (int i = 1; i <= test.length() - k ; i++)
		{
			
			String secondSub = test.substring(i, k + i);
			if (secondSub.compareTo(smallest) < 0)
			
				smallest = secondSub;
			if (secondSub.compareTo(largest) > 0)
				largest = secondSub;
		
		}
		return smallest + "\n" + largest;
	}
	
}
