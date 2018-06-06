import java.util.Arrays;
import java.util.Scanner;

public class P10_PairsBynumber {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int number = Integer.parseInt(in.nextLine());

        int counter = 0;

        for (int i = 0; i < arr.length; i++) {
            for (int j = i + 1; j < arr.length; j++) {
                if (Math.abs(arr[i] - arr[j]) == number) {
                    counter++;
                }
            }
        }
        System.out.println(counter);
    }
}
