import java.util.Arrays;
import java.util.Scanner;

public class P03_FoldAndSum {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] inputArray = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int[] leftFold = new int[inputArray.length / 4];
        int[] rightFold = new int[inputArray.length / 4];
        int[] resultArray = new int[inputArray.length / 2];

        for (int i = 0; i < (inputArray.length / 4); i++) {
            leftFold[i] = inputArray[(inputArray.length / 4) - 1 - i];
            rightFold[i] = inputArray[inputArray.length - 1 - i];
        }

        for (int i = 0; i < (inputArray.length / 4); i++) {
            resultArray[i] = leftFold[i] + inputArray[inputArray.length / 4 + i];
            resultArray[inputArray.length / 4 + i] = rightFold[i] + inputArray[inputArray.length / 2 + i];
        }

        for (int print : resultArray) {
            System.out.print(print + " ");
        }
    }
}
