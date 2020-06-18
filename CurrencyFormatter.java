import java.text.NumberFormat;
import java.util.Locale;

public class CurrencyFormatter {

	public static void main(String[] args) {
		double payment = 12324.134;
		NumberFormat us = NumberFormat.getCurrencyInstance(Locale.US);
		System.out.println(us.format(payment));
		Locale indiaLocale = new Locale("en", "IN");
		NumberFormat ind = NumberFormat.getCurrencyInstance(indiaLocale);
		System.out.println(ind.format(payment));

		NumberFormat chn = NumberFormat.getCurrencyInstance(Locale.CHINA);
		System.out.println(chn.format(payment));
		NumberFormat fra = NumberFormat.getCurrencyInstance(Locale.FRANCE);
		System.out.println(fra.format(payment));




	}

}
