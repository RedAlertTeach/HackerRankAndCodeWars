import java.math.BigInteger;

public class BigIntegerPrimality {

	public static void main(String[] args) {
                String s = "23498728979875982374298473248732498723423743274298";
                
               // String s = "13";

                BigInteger big = new BigInteger(s);
                if (big.isProbablePrime(4))
                {
                	System.out.println("prime");
                }
                else
                {
                	System.out.println("not prime");
                }
	}

}
