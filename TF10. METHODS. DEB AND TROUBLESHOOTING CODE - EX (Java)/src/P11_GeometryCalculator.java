import java.util.Scanner;

public class P11_GeometryCalculator {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String figureType = in.nextLine();
        double result;

        switch (figureType) {
            case "triangle":

                double a = Double.parseDouble(in.nextLine());
                double b = Double.parseDouble(in.nextLine());

                result = GetTriangleArea(a, b);
                System.out.printf("%.2f", result);
                break;

            case "square":

                double c = Double.parseDouble(in.nextLine());

                result = GetSquareArea(c);
                System.out.printf("%.2f", result);
                break;

            case "rectangle":

                double d = Double.parseDouble(in.nextLine());
                double e = Double.parseDouble(in.nextLine());

                result = GetRectangleArea(d, e);
                System.out.printf("%.2f", result);
                break;

            case "circle":

                double r = Double.parseDouble(in.nextLine());

                result = GetCircleArea(r);
                System.out.printf("%.2f", result);
                break;
        }

    }

    private static double GetCircleArea(double r) {
        return Math.PI * Math.pow(r, 2);
    }

    private static double GetRectangleArea(double a, double b) {
        return a * b;
    }

    private static double GetSquareArea(double a) {
        return Math.pow(a, 2);
    }

    private static double GetTriangleArea(double a, double b) {
        return (a * b) / 2;
    }
}
