
public class ArmyGameRunner {

    public static void main(String[] args) {
	int n = 83;
	int m = 179;
	System.out.println("The number of drops needed is " + calcDrops(n,m));

    }
    public static int calcDrops(int n, int m)
    {
	if (n == 1 && m == 1)  // both equal 1
	    return 1;
	else if (n == 1)       // 1 row
	    return m/2 + m%2;
	else if (m == 1)       // 1 column
	    return n/2 + n%2;
	else if ((n % 2 == 0) && (m % 2 == 0))  // rows and columns both even
	    return (n/2) * (m/2);
	else if (n % 2 == 0)
	    return  (n/2) * (m/2 + 1);    // columns even
	else if (m % 2 == 0)
	    return (m/2) * (n/2 + 1);     // rows even
	else
	    return (m/2 + 1) * (n/2 + 1); // rows and columns both odd
    }
    
    // the above condenses to this but I had to write it that way first to see it
    public static int calcDrops2(int n, int m)
    {
	 return (m/2 + m%2) * (n/2 + n%2); 
    }

}
