import java.math.BigDecimal;
import java.util.Scanner;

public class P10_CenturiesToNanoseconds {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int centuries = Integer.parseInt(in.nextLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;

        final BigDecimal VAL_1 = new BigDecimal(60);
        final BigDecimal VAL_2 = new BigDecimal(1000);

        BigDecimal hoursVal = new BigDecimal(hours);
        BigDecimal minutes = hoursVal.multiply(VAL_1);
        BigDecimal seconds = minutes.multiply(VAL_1);
        BigDecimal milliseconds = seconds.multiply(VAL_2);
        BigDecimal microseconds = milliseconds.multiply(VAL_2);
        BigDecimal nanoseconds = microseconds.multiply(VAL_2);

        System.out.printf("%d centuries = %d years = %d days = %d hours = %.0f minutes = %.0f seconds = %.0f milliseconds = %.0f microseconds = %.0f nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
    }
}
