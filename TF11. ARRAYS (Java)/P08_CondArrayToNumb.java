import java.util.Arrays;
import java.util.Scanner;

public class P08_CondArrayToNumb {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                    .map(String::trim).mapToInt(Integer::parseInt).toArray();

        while (arr.length > 1) {

            int[] condense = new int[arr.length - 1];

            for (int i = 0; i < condense.length; i++) {

                condense[i] = arr[i] + arr[i + 1];
            }
            arr = condense;
        }
        System.out.println(Arrays.toString(arr).replace("[","").replace("]",""));
    }
}
