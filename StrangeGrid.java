
public class StrangeGrid {

	public static void main(String[] args) {
		int row = 2000000000;
		int column = 2;
		System.out.println("The item in row " + row + " and column " + column + " is " + findNumber(row, column));
	}
	
	public static long findNumber(int row, int column)
	{
		long result = 0;
		if (row % 2 == 0)
		{
			row = row / 2 - 1;
			result = 10L * row;
			result += column * 2L - 1;
		}
		else
		{
			row = row / 2;
			result = 10L * row;
			result += column * 2L - 2;
		}
		return result;
	}

}
