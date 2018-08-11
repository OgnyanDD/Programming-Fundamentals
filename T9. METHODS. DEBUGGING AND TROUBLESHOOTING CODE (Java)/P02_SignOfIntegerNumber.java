import java.util.Scanner;

public class P02_SignOfIntegerNumber {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int inputNumber = Integer.parseInt(in.nextLine());
        PrintSign(inputNumber);
    }
    private static void PrintSign(int number) {

        if (number == 0) {
            System.out.printf("The number %d is zero.", number);
        } else if (number > 0) {
            System.out.printf("The number %d is positive.", number);
        } else {
            System.out.printf("The number %d is negative.", number);
        }
    }
}
