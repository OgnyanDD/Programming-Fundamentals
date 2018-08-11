import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class P07_PrimesInGivenRange {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        long start = Long.parseLong(in.nextLine());
        long end = Long.parseLong(in.nextLine());

        String result = new String(String.valueOf(ListOfPrimesInRange(start, end))).replace("[", "").replace("]", "");

        System.out.println(result);
    }

    static List<Long> ListOfPrimesInRange(long a, long b) {
        List<Long> listPrimes = new ArrayList<Long>();

        for (long i = a; i <= b; i++) {
            if (IsPrime(i)) {
                listPrimes.add(i);
            }
        }
        return listPrimes;
    }

    private static boolean IsPrime(long n) {
        boolean isPrime = true;
        if (n == 0 || n == 1) {
            isPrime = false;
        }
        for (int i = 2; i <= Math.sqrt(n); i++) {

            if (n % i == 0) {
                isPrime = false;
            }
        }
        return isPrime;
    }
}
