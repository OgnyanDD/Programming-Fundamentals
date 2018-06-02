import java.util.Scanner;

public class P06_RevAnArrayOfStr {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String[] input = in.nextLine().split(" ");

        for (int i = input.length - 1; i >= 0 ; i--) {

            System.out.print(input[i] + " ");
        }
    }
}
