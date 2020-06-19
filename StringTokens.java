
public class StringTokens {

	public static void main(String[] args) {
		   String s = "He is a very very good boy, isn't he?"; // 10 tokens
		//   String s = "           YES      leading spaces        are valid,    problemsetters are         evillllll"; // 8 tokens
	//	String s = "                        ";	// 0 tokens
		s = s.trim(); // trim leading spaces
		if (!s.equals(""))  // empty string results in 1 token, which is incorrect, so check for it
		{
			String[] tokens = s.split("[ !,?._'@]+");
			System.out.println(tokens.length);
			for (String token : tokens)
			{
				System.out.println(token);
			}
		}
		else
			System.out.println(0);
	}

}
