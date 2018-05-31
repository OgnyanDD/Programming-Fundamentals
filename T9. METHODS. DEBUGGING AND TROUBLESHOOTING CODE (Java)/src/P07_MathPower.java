import java.text.DecimalFormat;
import java.util.Scanner;

public class P07_MathPower {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double number = Double.parseDouble(in.nextLine());
        int power = Integer.parseInt(in.nextLine());

        DecimalFormat df = new DecimalFormat("#.####");

        System.out.println(df.format(MathPower(number, power)));
    }

    private static double MathPower(double number, int power) {
        return (Math.pow(number, power));
    }
}
