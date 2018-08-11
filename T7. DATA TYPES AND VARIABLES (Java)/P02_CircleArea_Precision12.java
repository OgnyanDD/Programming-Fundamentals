import java.util.Scanner;

public class P02_CircleArea_Precision12 {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double circleRadius = Double.parseDouble(in.nextLine());

        double circleArea = Math.PI * circleRadius * circleRadius;

        System.out.printf("%.12f", circleArea);
    }
}
