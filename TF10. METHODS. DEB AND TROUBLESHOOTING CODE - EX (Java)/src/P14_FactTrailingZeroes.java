import java.util.Scanner;

public class P14_FactTrailingZeroes {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int number = Integer.parseInt(in.nextLine());
        int result = CounterTrailingZeroesInFactorial(number);

        System.out.println(result);
    }

    private static int CounterTrailingZeroesInFactorial(int number) {

        int counterZeros = 0;
        if (number == 0) {
            counterZeros = 1;
        } else {
            for (int i = 5; number / i >= 1; i *= 5) {
                counterZeros += number / i;
            }
        }
        return counterZeros;
    }
}
