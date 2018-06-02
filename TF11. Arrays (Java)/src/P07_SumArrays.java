import java.util.Arrays;
import java.util.Scanner;

public class P07_SumArrays {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr1 = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int[] arr2 = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        if (arr1.length <= arr2.length)
        {
            int[] newArr2 = new int[arr2.length];

            for (int i = 0; i < newArr2.length; i++)
            {
                newArr2[i] = arr1[i % arr1.length] + arr2[i % arr2.length];

                if (i >= arr2.length)
                {
                    break;
                }
                System.out.print(newArr2[i] + " ");
            }
            System.out.println();
        }
        else
        {
            int[] newArr1 = new int[arr1.length];

            for (int i = 0; i < newArr1.length; i++)
            {
                newArr1[i] = arr1[i % arr1.length] + arr2[i % arr2.length];

                if (i >= arr1.length)
                {
                    break;
                }
                System.out.print(newArr1[i] + " ");
            }
            System.out.println();
        }
    }
}