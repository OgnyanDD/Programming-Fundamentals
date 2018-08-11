import java.util.Arrays;
import java.util.Scanner;

public class P07_MaxSeqOfIncrEl {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int longSeqLength = 1;
        int longSeqStart = 0;
        int currentSeqLength = 1;
        int currentSeqStart = 0;

        for (int i = 1; i < arr.length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                currentSeqLength++;

                if (currentSeqLength > longSeqLength)
                {
                    longSeqLength = currentSeqLength;
                    longSeqStart = currentSeqStart;
                }
            }
            else
            {
                currentSeqLength = 1;
                currentSeqStart = i;
            }
        }

        for (int i = longSeqStart; i < longSeqStart + longSeqLength; i++)
        {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }
}
