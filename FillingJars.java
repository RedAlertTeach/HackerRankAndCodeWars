import java.io.File;
import java.util.Scanner;

public class FillingJars {

	public static void main(String[] args) {

		int[][] candies = new int[][] { 
			{29, 40, 787},
			{9 ,26 ,219},
			{21 ,31, 214},
			{8 ,22 ,719},
			{15 ,23, 102},
			{11 ,24, 83},
			{14 ,22, 321},
			{5 ,22 ,300},
			{11 ,30 ,832},
			{5 ,25 ,29},
			{16 ,24, 577},
			{3 ,10 ,905},
			{15 ,22, 335},
			{29 ,35, 254},
			{9 ,20 ,20},
			{33 ,34, 351},
			{30 ,38, 564},
			{11 ,31, 969},
			{3 ,32 ,11},
			{29 ,35, 267},
			{4 ,24 ,531},
			{1 ,38 ,892},
			{12, 18, 825},
			{25, 32, 99},
			{3 ,39 ,107},
			{12, 37, 131},
			{3 ,26 ,640},
			{8 ,39 ,483},
			{8 ,11 ,194},
			{12, 37, 502}};

			try { 
				File file = new File("c:/users/loakley/downloads/fillingjars.txt");
				Scanner sc = new Scanner(file);
				int[][] operations = new int[10000000][3];
				int rowCtr = 0;
				while (sc.hasNextLine())
				{ 
					String[] operation = sc.nextLine().split(" ");
					operations[rowCtr][0] = Integer.parseInt(operation[0]);
					operations[rowCtr][1] = Integer.parseInt(operation[1]);
					operations[rowCtr][2] = Integer.parseInt(operation[2]);
					rowCtr++;
				}
				long avg = findAverage(10000000, operations);  // 1666288812
				System.out.println("The candy average is " + avg);
			}
			catch (Exception e)
			{
				System.out.println(e.getMessage());
			}
	}

	public static long findAverage(int n, int operations[][])
	{
		long sum = 0;
		for (int i = 0; i < operations.length; i++)
		{
			sum += (operations[i][1] - operations[i][0] + 1) * (long) operations[i][2]; //461,379,528,245
			
		}
		return sum / n;
	}
}
