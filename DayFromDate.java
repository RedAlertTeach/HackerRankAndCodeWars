import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.GregorianCalendar;

public class DayFromDate {

	public static void main(String[] args) {
		System.out.println("The day is " + findDay(8,5,2015));

	}
	public static String findDay(int month, int day, int year) {
		Date date = new GregorianCalendar(year, month - 1, day).getTime();	 
		String dayString = new SimpleDateFormat("EEEE").format(date).toUpperCase();
	    return dayString;
	    }


}
