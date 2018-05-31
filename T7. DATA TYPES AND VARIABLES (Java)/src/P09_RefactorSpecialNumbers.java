import java.util.Scanner;

public class P09_RefactorSpecialNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        for (int i = 1; i <= input; i++) {
            int sumOfDigits = 0;
            int digits = i;
            boolean special = false;

            while (digits > 0) {

                sumOfDigits += digits % 10;
                digits /= 10;
            }

            if (special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11)) {

                System.out.printf("%d -> True\n", i);
            } else {
                System.out.printf("%d -> False\n", i);
            }
        }
    }
}
