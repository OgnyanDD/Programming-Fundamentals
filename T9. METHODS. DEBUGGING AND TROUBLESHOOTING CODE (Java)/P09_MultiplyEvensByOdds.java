import java.util.Scanner;

public class P09_MultiplyEvensByOdds {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        input = Math.abs(input);
        System.out.println(OddEvenSum(input));
    }

    private static int OddEvenSum(int number) {

        int sumEven = 0;
        int sumOdd = 0;

        while (number > 0) {

            int temp = number % 10;

            if (temp % 2 == 0) {

                sumEven += temp;

            } else {

                sumOdd += temp;
            }
            number /= 10;
        }
        return (sumEven * sumOdd);
    }
}