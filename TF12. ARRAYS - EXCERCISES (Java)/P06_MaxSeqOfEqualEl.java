import java.util.Arrays;
import java.util.Scanner;

public class P06_MaxSeqOfEqualEl {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int start = 0;
        int bestStart = 0;
        int counter = 0;
        int bestLength = 0;


        for (int i = 1; i < arr.length; i++) {

            if (arr[start] == arr[i]) {
                counter++;

                if (counter > bestLength) {
                    bestLength = counter;
                    bestStart = start;

                }
            } else {
                start++;
                i = start;
                counter = 0;
            }

        }
        for (int i = 0; i <= bestLength; i++) {
            System.out.print(arr[bestStart + i] + " ");
        }
        System.out.println();
    }
}
