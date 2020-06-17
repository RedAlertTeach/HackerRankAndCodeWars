import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class EqualStacks {

	public static void main(String[] args) {
		int[] first = new int[] { 3, 2, 1, 1, 1 };
		int[] second = new int[] { 4, 3, 2 };
		int[] third = new int[] { 1, 1, 4, 1 };
		
		int highest = findEqualHeights(first, second, third);
		System.out.println("The highest possible stack is " + highest);

	}
	public static int findEqualHeights(int[] h1, int[] h2, int[] h3)
	{
		int result = 0;
		for (int i = h3.length - 1; i > 0; i--)
		{
			h3[i - 1] += h3[i];
			
		}
		for (int i = h2.length - 1; i > 0; i--)
		{
			h2[i - 1] += h2[i];
			
		}
		for (int i = h1.length - 1; i > 0; i--)
		{
			h1[i - 1] += h1[i];
			
		}
		
		int[] shortest;
		int[] other1;
		int[] other2;
		if (h1.length <= h2.length && h1.length <= h3.length)
		{
			shortest = h1;
			other1 = h2;
			other2 = h3;
		}
		else if (h2.length <= h1.length && h2.length <= h3.length)
		{
			shortest = h2;
			other1 = h1;
			other2 = h3;
		}
		else
		{
			shortest = h3;
			other1 = h2;
			other2 = h1;
		}
		
		for (int i = 0; i < shortest.length; i++)
		{
			
			if (arrayContains(other1, shortest[i]) && arrayContains(other2,shortest[i]))
				return shortest[i];
		}
		return result;
	}
    public static boolean arrayContains(int[] a, int n)
    {
    	
    	for (int i = 0; i < a.length; i++)
    	{
    		if (a[i] == n)
    			return true;
    	}
    	return false;
    }
}
