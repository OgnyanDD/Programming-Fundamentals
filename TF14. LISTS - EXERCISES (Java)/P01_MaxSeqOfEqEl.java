import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P01_MaxSeqOfEqEl {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Integer> input = Arrays.stream(in.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int maxNumber = 0;
        int maxCounter = 0;

        for (int num1 : input) {
            int counter = 0;

            for (int num2 : input) {
                if (num1 == num2) {
                    counter++;
                }
            }

            if (counter > maxCounter) {
                maxCounter = counter;
                maxNumber = num1;
            }
        }

        for (int i = 0; i < maxCounter; i++) {
            System.out.printf("%d ", maxNumber);
        }
        System.out.println();
    }
}
