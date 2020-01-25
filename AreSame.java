
public class AreSame {

    public static void main(String[] args) {
	int[] a =  {121, 144, 19, 161, 19, 144, 19, 11};
	int[] b = {121, 14641, 20736, 361, 25921, 361, 20736, 361};

	System.out.println("The arrays are the 'same': " + compareArrays(a,b));

    }
    public static boolean compareArrays(int[] a, int[] b)
    {
	
	if (a == null || b ==  null)
	    return false;
	if (a.length != b.length)
		return false;
	
	int[] aSorted = new int[3000000];
	int[] bSorted = new int[3000000];
	
	for (int i = 0; i < a.length; i++)
	
	    aSorted[Math.abs(a[i])]++;
	
	for (int i = 0; i < b.length; i++)
	{
	    if (b[i] < 0)
		return false;
	    bSorted[b[i]]++;
	}
	
	for (int i = 0; i < aSorted.length; i++)
	{
		if (aSorted[i] != 0)
	    {
		if (bSorted[(int)Math.pow(i, 2)] != aSorted[i])
		    return false;
	    }
	}
	return true;
    }

}


