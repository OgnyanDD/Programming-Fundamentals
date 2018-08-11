import java.util.Scanner;

public class P11_OddNumber {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        for (int i = 0; i < 10; i++) {
            int inputNumber = Integer.parseInt(in.nextLine());
            inputNumber = Math.abs(inputNumber);
            if (inputNumber % 2 == 0) {
                System.out.println("Please write an odd number.");
            } else {
                System.out.printf("The number is: %d", inputNumber);
                break;
            }
        }
    }
}
