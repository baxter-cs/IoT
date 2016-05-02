package oxford;

import java.text.SimpleDateFormat;
import java.util.Calendar;

public class HelloWorld {
	
	public static void main(String[] args){
		System.out.println("Explore, Dream, Discover!");
		
		Calendar cal = Calendar.getInstance();
		SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
		System.out.println(dateFormat.format(cal.getTime()));
	
	}
}