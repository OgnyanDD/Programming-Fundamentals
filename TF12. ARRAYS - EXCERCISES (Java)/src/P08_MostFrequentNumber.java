import java.util.Arrays;
import java.util.Scanner;

public class P08_MostFrequentNumber {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int maxNumber = 0;
        int maxCounter = 0;

        for (int i = 0; i < arr.length; i++) {

            int counter = 0;

            for (int j = i; j < arr.length; j++) {

                if (arr[i] == arr[j]) {

                    counter++;
                }
            }
            if (counter > maxCounter) {

                maxCounter = counter;
                maxNumber = arr[i];
            }
        }
        System.out.println(maxNumber);
    }
}
