import java.util.Scanner;

public class P06_IntervalOfNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int firstNumber = Integer.parseInt(in.nextLine());
        int secondNumber = Integer.parseInt(in.nextLine());

        if (firstNumber < secondNumber) {

            for (int i = firstNumber; i <= secondNumber; i++) {

                System.out.println(i);
            }
        } else {

            for (int i = secondNumber; i <= firstNumber; i++) {

                System.out.println(i);
            }
        }
    }
}
