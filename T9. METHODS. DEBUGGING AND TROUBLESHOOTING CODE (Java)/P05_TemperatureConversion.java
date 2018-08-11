import java.util.Scanner;

public class P05_TemperatureConversion {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double input = Double.parseDouble(in.nextLine());

        System.out.printf("%.2f", ConverterFToC(input));
    }

    private static double ConverterFToC(double converter) {

        return (converter - 32) * 5 / 9;
    }
}
