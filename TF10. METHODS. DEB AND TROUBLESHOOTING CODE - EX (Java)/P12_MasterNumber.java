import java.util.Scanner;

public class P12_MasterNumber {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int n = Integer.parseInt(in.nextLine());

        for (int num = 1; num < n; num++) {

            if (IsPalindrome(num) && SumOfDigits(num) && ContainEvenDigit(num)) {

                System.out.println(num);
            }
        }
    }

    private static boolean IsPalindrome(int num) {
        int n = num;
        int reverse = 0;
        while (num > 0) {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num = num / 10;
        }
        return n == reverse;
    }

    private static boolean SumOfDigits(int num) {
        int sum = 0;
        while (num > 0) {
            sum += num % 10;
            num = num / 10;
        }
        return sum % 7 == 0;
    }

    private static boolean ContainEvenDigit(int num) {
        while (num > 0) {
            if (num % 10 % 2 == 0) return true;
            num /= 10;
        }
        return false;
    }
}

