import java.util.Arrays;
import java.util.Scanner;

public class P06_SumRevNumb {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int[] input = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        int sum = 0;

        for (int i = 0; i < input.length; i++)
        {
            int rev = 0;
            while (input[i] > 0)
            {

                int digit = input[i] % 10;
                rev = rev * 10 + digit;
                input[i] = input[i] / 10;
            }
            sum += rev;
        }
        System.out.println(sum);
    }
}
