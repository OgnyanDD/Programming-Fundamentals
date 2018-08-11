import java.util.Scanner;

public class P06_PrimeChecker {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        long num = Long.parseLong(in.nextLine());

        System.out.println(CheckPrime(num));
    }

    private static String CheckPrime(long n) {

        if (n <= 1) {
            return "False";
        }
        if (n == 2) {
            return "True";
        }
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) {
                return "False";
            }
        }
        return "True";
    }
}