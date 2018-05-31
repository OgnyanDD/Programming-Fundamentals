import java.text.DecimalFormat;
import java.util.Scanner;

public class P01_CenturiesToMinutes {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int centuries = Integer.parseInt(in.nextLine());
        int years = centuries * 100;
        double days = Math.round(years * 365.2422);
        double hours = Math.round(days * 24);
        double minutes = Math.round(hours * 60);
        DecimalFormat df = new DecimalFormat("#.################");

        System.out.println(centuries + " centuries = " + years + " years = " + df.format(days) + " days = " + df.format(hours) + " hours = " + df.format(minutes) + " minutes");
    }
}
