import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class DivisiblePermutations {
	static List<String> divisors = new ArrayList<String> (Arrays.asList("008", "016", "024", "032", "040", "048", "056", "064", "072", "080", "088", "096" ));

	public static void main(String[] args) {

		String n = "38510";

		/*
		 * String[] inputs = new String[] {"30",
		 * "622410520951119659474260428645479810874889290178235653828802469540739",
		 * "6937950733011840228264059488970355270344865961", "89",
		 * "8326288966858133604960747818014247087075760793355961936649640186005714",
		 * "816",
		 * "31297161019858518815822736359941172988010197969960644839784681998108221233129026382798786344456",
		 * "2738942274596971991098863428982677664901572369589600696931951418196507974113383",
		 * "5442",
		 * "6404355784070689756889164529064324759449846126294802931315312964351497303136857449653914567753",
		 * "61", "5793", "90",
		 * "734002661316220907652172734045978390766117752852730257443077664696692205170375871098752269",
		 * "33", "7972466881952359320318263542560167625203400855787030059303872810",
		 * "2441597595275247577363591311640574625406123670327373834188242491053515130717771629902",
		 * "813567958122649999606578199211823399106918392393274133",
		 * "26096371800731532", "39", "69", "24", "67", "38510",// this one "67",
		 * "353051260", "869387581029398008288553704086691531482714843666616461944",
		 * "6312", "4056558584347213822383447", "431464332182696",
		 * "4614106357693696810676917933814268670505296578151430221916409045805875596473"
		 * };
		 */
		for (int i = 104; i < 1000; i++)
		{
			if (i % 8 == 0)
				divisors.add(String.valueOf(i));
		}

		//	for (String n : inputs)
		//	{
		String result = findPermutation(n);

		System.out.println(result);
		//	}



	}

	public static String findPermutation(String n)
	{
		String result = "NO";


		// if the string representation of the number has only two digits
		// check for even division by 8 forward and backward
		if (n.length() < 3)
			if (Integer.parseInt(n) % 8 == 0  || Integer.parseInt(new StringBuilder(n).reverse().toString()) % 8 == 0)
				return "YES";
			else 
				return "NO";

		// use counting sort to log the occurrences of each digit
		int[] counts = new int[10];


		for (int i = 0; i < n.length(); i++)
		{
			counts[n.charAt(i) - '0']++;
		}

		// SPECIAL CASE: if there are at least three '0's return "YES"
		if (counts[0] >= 3)
			return "YES";

		// otherwise check for the occurrence of at least one digit of each divisor
		// as soon as one is found, stop and return "YES"
		for (String s : divisors)
		{
			
			if (counts[s.charAt(0) - '0'] > 0 && counts[s.charAt(1) - '0'] > 0 && counts[s.charAt(2) - '0'] > 0)
			{
				// prevent false positive for factors with repeating 8's or 0's
				if ((s.equals("008") && (counts[0] < 2 || counts[8] < 1)) ||
					(s.equals("080") && (counts[0] < 2 || counts[8] < 1)) ||
					(s.equals("088") && (counts[0] < 1 || counts[8] < 2)) ||
					(s.equals("800") && (counts[0] < 2 || counts[8] < 1)) ||
					(s.equals("808") && (counts[0] < 1 || counts[8] < 2)) ||
					(s.equals("880") && (counts[0] < 1 || counts[8] < 2)) ||
					(s.equals("888") && (counts[8] < 3)))
					result = "NO";
				else
				{
				result = "YES";
				break;
				}
			}
		}
		
		return result;
	}

}
