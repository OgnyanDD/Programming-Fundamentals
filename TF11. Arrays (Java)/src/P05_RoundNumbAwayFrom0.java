import java.util.Scanner;

public class P05_RoundNumbAwayFrom0 {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String[] numbers = in.nextLine().split(" ");

        for (int i = 0; i < numbers.length; i++) {

            double numb = Double.parseDouble(numbers[i]);
            System.out.printf("%s => %.0f\n", numbers[i], numb);
        }
    }
}
