import java.text.DecimalFormat;
import java.util.Scanner;

public class P09_LongerLine {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double x1 = Double.parseDouble(in.nextLine());
        double y1 = Double.parseDouble(in.nextLine());
        double x2 = Double.parseDouble(in.nextLine());
        double y2 = Double.parseDouble(in.nextLine());
        double x3 = Double.parseDouble(in.nextLine());
        double y3 = Double.parseDouble(in.nextLine());
        double x4 = Double.parseDouble(in.nextLine());
        double y4 = Double.parseDouble(in.nextLine());

        PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
    }

    private static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) {
        double line1 = CalculatePythagorean(Math.pow(x2 - x1, 2), Math.pow(y2 - y1, 2));
        double line2 = CalculatePythagorean(Math.pow(x4 - x3, 2), Math.pow(y4 - y3, 2));

        if (line1 >= line2) {
            PrintCloserLine(x1, y1, x2, y2);
        } else {
            PrintCloserLine(x3, y3, x4, y4);
        }
    }

    private static void PrintCloserLine(double x1, double y1, double x2, double y2) {
        DecimalFormat df = new DecimalFormat("#.#################");

        double line1 = CalculatePythagorean(x1, y1);
        double line2 = CalculatePythagorean(x2, y2);

        if (line1 <= line2) {
            System.out.println(("(" + df.format(x1) + ", " + df.format(y1) + ")(" + df.format(x2) + ", " + df.format(y2) + ")"));
        } else {
            System.out.println(("(" + df.format(x2) + ", " + df.format(y2) + ")(" + df.format(x1) + ", " + df.format(y1) + ")"));
        }
    }

    private static double CalculatePythagorean(double x, double y) {
        double result = Math.sqrt((x * x) + (y * y));

        return result;
    }
}
