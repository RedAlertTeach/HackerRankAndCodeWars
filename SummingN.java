import java.math.BigInteger; 

public class SummingN {

    public static void main(String[] args) {
	long[] input = new long[] {2, 1, 5351871996120528L,
		2248813659738258L,
		2494359640703601L,
		6044763399160734L,
		3271269997212342L,
		4276346434761561L,
		2372239019637533L,
		5624204919070546L,
		9493965694520825L,
		8629828692375133L};
	for (int i = 0; i < input.length; i++)
	{    
	long n = doTheSum(input[i]);
	System.out.println("The series sum of " + input[i] + " is " + n);
	}

    }
    public static long doTheSum(long N)
    {
	BigInteger sum = BigInteger.ONE;
	BigInteger bigN = BigInteger.valueOf(N);
	BigInteger nSquared = bigN.multiply(bigN);
	BigInteger nMinusOne = bigN.subtract(BigInteger.ONE);
	BigInteger nMinusOneSquared = nMinusOne.multiply(nMinusOne);
	BigInteger diff = nSquared.subtract(nMinusOneSquared);
	sum = sum.add(diff);
	sum = sum.multiply(bigN);
	BigInteger two = new BigInteger("2");
	sum = sum.divide(two);
	BigInteger modulo = BigInteger.valueOf(1000000007);
	sum = sum.mod(modulo);
	return sum.longValue();
/*	    sum.add(N * N - (N - 1) * (N - 1));
	    sum.multiply *= N;
	    sum /= 2;
	
	long result = sum % (1000000007L); 
	return result; */
    }

}
