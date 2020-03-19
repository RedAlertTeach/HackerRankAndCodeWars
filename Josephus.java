import java.util.ArrayList;
import java.util.List;

public class Josephus {
    static List<Integer> powersOf2 = new ArrayList<Integer>();
	public static void main(String[] args) {
		generatePowers();
        int n = 32;
        int survivor = findJosephusNumber(n);
        System.out.println("The survivor for " + n + " prisoners is " + survivor);
	}
    public static void generatePowers()
    {
    	for (int i = 0; i < 32; i++)
    	{
    		powersOf2.add((int)Math.pow(2,i));
    	}
    }
    public static int findJosephusNumber(int n)
    {
    	// will only work for numbers up to 2^32 (integer)
    	int survivor = 0;
    	int index = 0;
    	while (survivor == 0)
    	{
    		int nextPower = powersOf2.get(index);
    		if (nextPower == n)
    			return 1;
    		else if (nextPower < n)
    			index++;
    		else
    			survivor = 2 * (n - powersOf2.get(index - 1)) + 1;
    	}
    	return survivor;
    	
    }
}
