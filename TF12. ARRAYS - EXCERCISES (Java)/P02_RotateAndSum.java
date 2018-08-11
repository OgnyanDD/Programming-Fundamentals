import java.util.Arrays;
import java.util.Scanner;

public class P02_RotateAndSum {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int iterations = Integer.parseInt(in.nextLine());

        int[] sumArr = new int[arr.length];

        for (int i = 0; i < iterations; i++) {

            reverseArr(arr);
            sumArray(arr, sumArr);
        }
        for (int result : sumArr) {

            System.out.print(result + " ");
        }
    }

    private static void sumArray(int[] arr, int[] sumArr) {

        for (int i = 0; i < sumArr.length; i++) {

            sumArr[i] += arr[i];
        }
    }

    private static void reverseArr(int[] arr) {

        int temp = arr[arr.length - 1];

        for (int i = arr.length - 1; i > 0; i--) {

            arr[i] = arr[i - 1];
        }
        arr[0] = temp;
    }
}
