import java.util.Scanner;

public class P04_NumbInRevOrder {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String input = in.nextLine();

        System.out.println(ReverseNumber(input));
    }

    private static String ReverseNumber(String n) {

        char[] digits = n.toCharArray();
        String reverseDigit = "";

        for (int i = n.length() - 1; i >= 0; i--) {

            reverseDigit += digits[i];
        }
        return reverseDigit;
    }
}
