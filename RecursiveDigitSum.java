
public class RecursiveDigitSum {

	public static void main(String[] args) {

		int number = 148;

		System.out.println("The super digit of " + number + " is " + SuperDigit(number));
		
		String numberS = "123";
		System.out.println("The super digit of " + numberS + " as a string is with factor 3 is " + SuperDigitString(numberS, 3));

	}

	public static int SuperDigit(int number)
	{
		if (number > 9)
		{
			int sum = 0;
			while (number != 0)
			{
				sum += number % 10;
				number /= 10;
			}
			return SuperDigit(sum);
		}
		else
			return number;
	}
	public static int SuperDigitString(String number, int k)
	{
		if (number.length() > 1)
		{
			long sum = 0;
			for (int i = 0; i < number.length(); i++)
			{
				sum += Character.getNumericValue(number.charAt(i));
			}
			return SuperDigitString(Long.toString(sum * k), 1);
		}
		else
			return Character.getNumericValue(number.charAt(0));
	}

}
