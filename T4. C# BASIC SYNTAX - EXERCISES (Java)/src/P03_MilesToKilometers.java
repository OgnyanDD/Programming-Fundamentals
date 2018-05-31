import java.util.Scanner;

public class P03_MilesToKilometers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        final double MILE_KM = 1.60934;
        double input = Double.parseDouble(in.nextLine());
        double converter = input * MILE_KM;

        System.out.printf("%.2f", converter);
    }
}
