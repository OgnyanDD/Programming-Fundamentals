import java.text.DecimalFormat;
import java.util.Scanner;

public class P06_CalculateTriangleArea {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double width = Double.parseDouble(in.nextLine());
        double height = Double.parseDouble(in.nextLine());
        double area = GetTriangleArea(width, height);

        DecimalFormat df = new DecimalFormat("#.#######");
        System.out.println(df.format(area));
    }
    private static double GetTriangleArea(double width, double height) {

        return ((width * height) / 2);
    }
}