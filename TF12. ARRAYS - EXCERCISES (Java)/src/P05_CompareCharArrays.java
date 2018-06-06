import java.util.Arrays;
import java.util.Scanner;

public class P05_CompareCharArrays {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String first = in.nextLine();
        String second = in.nextLine();

        char[] arr1 = first.replace(" ", "").toCharArray();
        char[] arr2 = second.replace(" ", "").toCharArray();

        if (arr1.length == arr2.length)
        {
            if (arr1[0] < arr2[0])
            {
                System.out.println(arr1);
                System.out.println(arr2);
            }
            else
            {
                System.out.println(arr2);
                System.out.println(arr1);
            }
        }
        else if (arr1.length > arr2.length)
        {
            System.out.println(arr2);
            System.out.println(arr1);
        }
        else
        {
            System.out.println(arr1);
            System.out.println(arr2);
        }
    }
}
