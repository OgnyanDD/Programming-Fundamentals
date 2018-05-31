import java.util.Scanner;

public class P04_DrawAFilledSquare {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        TopBottomLine(input);
        BodyPart(input);
        TopBottomLine(input);
    }

    private static void TopBottomLine(int n) {

        System.out.println(new String(new char[2 * n]).replace("\0", "-"));
    }

    private static void BodyPart(int n) {

        for (int i = 0; i < n - 2; i++) {

            System.out.print('-');

            for (int j = 1; j < n; j++) {

                System.out.print("\\/");
            }
            System.out.println('-');
        }
    }
}
