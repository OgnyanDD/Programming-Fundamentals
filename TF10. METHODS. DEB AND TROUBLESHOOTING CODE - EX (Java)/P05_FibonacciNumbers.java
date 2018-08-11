import java.util.Scanner;

public class P05_FibonacciNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        long input = Long.parseLong(in.nextLine());

        System.out.println(FibonacciNumber(input));
    }

    private static long FibonacciNumber(long n) {

        long a = 1;
        long b = 1;

        for (int i = 0; i < n - 1; i++) {

            long c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}
