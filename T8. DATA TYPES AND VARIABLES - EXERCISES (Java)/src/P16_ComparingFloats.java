import java.util.Scanner;

public class P16_ComparingFloats {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double num1 = Double.parseDouble(in.nextLine());
        double num2 = Double.parseDouble(in.nextLine());
        final double eps = 0.000001;

        double difference = Math.abs(num1 - num2);
        boolean result = difference < eps;

        if (result) {
            System.out.println("True");
        } else {
            System.out.println("False");
        }
    }
}
