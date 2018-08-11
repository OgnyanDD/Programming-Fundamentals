import java.util.Scanner;

public class P02_RevArrayOfInt {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        int[] numbers = new int[input];

        for (int i = 0; i < input; i++) {

            numbers[i] = Integer.parseInt(in.nextLine());
        }
        for (int i = numbers.length - 1; i >= 0; i--) {

            System.out.print(numbers[i] + " ");
        }
    }
}
