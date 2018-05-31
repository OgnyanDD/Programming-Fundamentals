import java.text.DecimalFormat;
import java.util.Scanner;

public class P12_RectangleProperties {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double width = Double.parseDouble(in.nextLine());
        double height = Double.parseDouble(in.nextLine());

        double area = width * height;
        double perimeter = (2 * (width + height));
        double diagonal = Math.sqrt(Math.pow(width, 2) + Math.pow(height, 2));

        DecimalFormat df = new DecimalFormat("#.#############");

        System.out.println(df.format(perimeter));
        System.out.println(df.format(area));
        System.out.println(df.format(diagonal));
    }
}
