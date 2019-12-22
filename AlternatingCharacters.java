
public class AlternatingCharacters {

	public static void main(String[] args) {
		String s1 = "AAAA";
		String s2 = "BBBBB";
		String s3 = "ABABABAB";
		String s4 = "BABABA";
		String s5 = "AAABBB";
		System.out.println("The number of deletions required for " + s1 + " is " + numberOfRemovals(s1));
		System.out.println("The number of deletions required for " + s2 + " is " + numberOfRemovals(s2));
		System.out.println("The number of deletions required for " + s3 + " is " + numberOfRemovals(s3));
		System.out.println("The number of deletions required for " + s4 + " is " + numberOfRemovals(s4));
		System.out.println("The number of deletions required for " + s5 + " is " + numberOfRemovals(s5));

		
	}
	public static int numberOfRemovals(String s) 
	{
	   int count = 0;
	   for (int i = 1; i < s.length(); i++)
	   {
		   if (s.charAt(i-1) == s.charAt(i))
			   count++;
	   }
	   return count;
	}

}
