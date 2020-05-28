import java.util.ArrayList;

public class SteppingStones {

	public static void main(String[] args) {
       int n = 3;
      
       double x  = (-1 + Math.sqrt(1 + 8 * n))/2;
       
       int y = (int) x;
       if (x == y)
          System.out.println("Go On Bob " + y);
       else
    	  System.out.println("Better Luck Next Time");
	}

}
