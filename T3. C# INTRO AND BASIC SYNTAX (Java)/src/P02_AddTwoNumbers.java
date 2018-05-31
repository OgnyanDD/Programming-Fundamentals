import java.util.Scanner;

public class P02_AddTwoNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int firstNumber = Integer.parseInt(in.nextLine());
        int secondNumber = Integer.parseInt(in.nextLine());
        int sum = firstNumber + secondNumber;

        System.out.printf("%d + %d = %d", firstNumber, secondNumber, sum);
    }
}
