import java.util.ArrayList;

public class IsFibo {

	public static void main(String[] args) {

       generateFibos(10000000000L);
       
       Long number = 8L;
       
       System.out.println(isFibo(number));
	}
	
	public static ArrayList<Long> fibos = new ArrayList<Long>();
	
	public static void generateFibos(long max)
	{
		long prev = 1;
		long curr = 1;
		long fib = prev + curr;
		fibos.add(curr);
		fibos.add(fib);
		while (fib < max)
		{
			prev = curr;
			curr = fib;
			fib = prev + curr;
			fibos.add(fib);
		}

		
	}
	public static String isFibo(Long number)
	{
		if (fibos.contains(number))
			return "IsFibo";
		else
			return "IsNotFibo";
	}

}
