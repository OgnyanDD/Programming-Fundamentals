import java.util.Scanner;

public class P05_SpecialNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        for (int i = 1; i <= input; i++) {

            int sum = 0;
            int digit = i;

            while (digit > 0) {

                sum += digit % 10;
                digit /= 10;
            }
            if (sum == 5 || sum == 7 || sum == 11) {

                System.out.printf("%d -> True\n", i);

            } else {

                System.out.printf("%d -> False\n", i);
            }
        }
    }
}
