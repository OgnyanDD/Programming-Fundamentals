import java.util.Scanner;

public class P01_LargestCommonEnd {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String[] arr1 = in.nextLine().split(" ");
        String[] arr2 = in.nextLine().split(" ");

        int lenghtLoop = Math.min(arr1.length, arr2.length);

        int counterLeft = 0;
        int counterRight = 0;

        for (int i = 0; i < lenghtLoop; i++) {

            if (arr1[i].equals(arr2[i])) {

                counterLeft++;
            }
            if (arr1[arr1.length - 1 - i].equals(arr2[arr2.length - 1 - i])) {

                counterRight++;
            }
        }
        System.out.println(Math.max(counterLeft, counterRight));
    }
}
