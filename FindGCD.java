public static int findGCD(int a, int b)
	{
		if (a == 0)
			return b;
		else if (b == 0)
			return a;
		else
			return findGCD(b, a % b);
	}