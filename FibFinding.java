

public class FibFinding {

	public static void main(String[] args) {
		int a = 3;
		int b = 7;
		int n = 5;
		System.out.println("The result is " + findFib(a, b, n));

	}
	// Does not work for the large test cases on HackerRank.
	// There was some sort of matrix math that would provide a shortcut.
	// This is brute force.
	public static int findFib(int a, int b, int n)
	{
		if (n == 0)
			return a;
		else if (n == 1)
			return b;
		else
		{
			
			int prev = a;
			int curr = b;
			int count = 2;
			while (count <= n)
			{
				int newFib = prev + curr;
				prev = curr;
				curr = newFib;
				count++;
			}
			return curr;
		}
		 
	}
}
