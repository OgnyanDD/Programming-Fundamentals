import java.util.FormatterClosedException;
import java.util.Scanner;

public class P12_NumberChecker {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        try {
            Double.parseDouble(in.nextLine());
            System.out.println("It is a number.");
        } catch (NumberFormatException exception) {
            System.out.println("Invalid input!");
        }
    }
}
