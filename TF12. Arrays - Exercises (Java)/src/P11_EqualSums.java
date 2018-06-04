import java.util.Arrays;
import java.util.Scanner;

public class P11_EqualSums {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] numbers = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int totalSum = 0;

        for (int numb : numbers) {
            totalSum += numb;
        }

        int leftSum = 0;
        int rightSum = totalSum;
        boolean hasFound = false;

        for (int i = 0; i < numbers.length; i++) {
            int currentNumber = numbers[i];
            rightSum -= currentNumber;


            if (leftSum == rightSum) {
                System.out.println(i);
                hasFound = true;
                break;
            }
            leftSum += currentNumber;
        }
        if (!hasFound) {
            System.out.println("no");
        }
    }
}
