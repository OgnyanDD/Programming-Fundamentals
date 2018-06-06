import java.util.Arrays;
import java.util.Scanner;

public class P09_ExtractMiddle {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        if (arr.length == 1)
        {
            System.out.println(Arrays.toString(arr).replace("[","").replace("]",""));
        }
        else if (arr.length % 2 == 0)
        {
            int[] evenArr = new int[2];


            evenArr[0] = arr[(arr.length / 2) - 1];

            evenArr[1] = arr[arr.length / 2];

            System.out.println(Arrays.toString(evenArr).replace("[","").replace("]",""));
        }
        else if (arr.length % 2 != 0)
        {
            int[] oddArr = new int[3];

            oddArr[0] = arr[(arr.length / 2) - 1];

            oddArr[1] = arr[arr.length / 2];

            oddArr[2] = arr[(arr.length / 2) + 1];

            System.out.println(Arrays.toString(oddArr).replace("[","").replace("]",""));
        }
    }
}
