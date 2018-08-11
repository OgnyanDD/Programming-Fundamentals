import java.math.BigInteger;
import java.util.Scanner;

public class P13_Factorial {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        BigInteger result = Factorial(input);

        System.out.println(result);

    }

    private static BigInteger Factorial(int input) {
        BigInteger result = BigInteger.ONE;

        for (int i = 1; i <= input; i++) {
            result = result.multiply(BigInteger.valueOf(i));
        }
        return result;
    }
}