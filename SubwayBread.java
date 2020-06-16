

public class SubwayBread {

	public static void main(String[] args) {
		
		
		int l = 6;
		int b = 9;  
		System.out.println("The number of squares of largest size is " + findSquares(l,b));
		
		
	}
	
	public static int findSquares(int l, int b)
	{
		if (l == b)
			return 1;
	
	    int gcd = findGCD(l, b);
	    return ((l/gcd) * (b/gcd));
	    
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
