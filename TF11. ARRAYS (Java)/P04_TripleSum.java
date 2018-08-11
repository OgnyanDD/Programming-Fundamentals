import java.util.Arrays;
import java.util.Scanner;

public class P04_TripleSum {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] numbers = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        boolean notFound = true;

        for (int i = 0; i < numbers.length; i++) {
            for (int y = i + 1; y < numbers.length; y++) {
                for (int number : numbers) {
                    if (numbers[i] + numbers[y] == number) {

                        System.out.printf("%d + %d == %d\n", numbers[i], numbers[y], number);
                        notFound = false;
                        break;
                    }
                }
            }
        }
        if (notFound) {
            System.out.println("No");
        }
    }
}
