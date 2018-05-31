import java.util.Scanner;

public class P02_RectangleArea {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double width = Double.parseDouble(in.nextLine());
        double height = Double.parseDouble(in.nextLine());

        double area = width * height;

        System.out.printf("%.2f", area);
    }
}
