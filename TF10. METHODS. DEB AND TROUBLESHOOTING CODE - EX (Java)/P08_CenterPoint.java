import java.text.DecimalFormat;
        import java.util.Scanner;

public class P08_CenterPoint {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double x1 = Double.parseDouble(in.nextLine());
        double y1 = Double.parseDouble(in.nextLine());
        double x2 = Double.parseDouble(in.nextLine());
        double y2 = Double.parseDouble(in.nextLine());

        PrintNearestToCenter(x1, y1, x2, y2);
    }

    private static void PrintNearestToCenter(double x1, double y1, double x2, double y2) {
        double first = Math.sqrt(Math.pow(y1, 2) + Math.pow(x1, 2));
        double secound = Math.sqrt(Math.pow(y2, 2) + Math.pow(x2, 2));

        DecimalFormat df = new DecimalFormat("#.###############################");
        if (first < secound) {
            System.out.println("(" + df.format(x1) + ", " + df.format(y1) + ")");
        } else {
            System.out.println("(" + df.format(x2) + ", " + df.format(y2) + ")");
        }
    }
}
