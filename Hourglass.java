
public class Hourglass {

	public static void main(String[] args) {
       int[][] numbers = new int[][] {
    	   {1, 1, 1, 0, 0, 0},
    	   {0, 1, 0, 0, 0, 0},
    	   {1, 1, 1, 0, 0, 0},
    	   {0, 0, 2, 4, 4, 0},
    	   {0, 0, 0, 2, 0, 0},
    	   {0, 0, 1, 2, 4, 0}};
    	   
    	   System.out.println(getLargestHourglass(numbers));
	}
	
	public static int getLargestHourglass(int[][] numbers)
	{
		int largest = Integer.MIN_VALUE;
		int sum = Integer.MIN_VALUE;

		for (int i = 0; i < numbers.length - 2; i++)
		{
			for (int j = 0; j < numbers[i].length - 2; j++)
			{
				sum = numbers[i][j] + numbers[i][j+1] + numbers[i][j+2] +
						               numbers[i+1][j+1]  +
					   numbers[i+2][j] + numbers[i+2][j+1] + numbers[i+2][j+2];
				if (sum > largest)
					largest = sum;
				sum = Integer.MIN_VALUE;
			}
			
		}
		return largest;
	}

}
