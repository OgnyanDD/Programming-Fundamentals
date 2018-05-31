import java.util.Scanner;

public class P10_MultiplicationTable_2 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int n = Integer.parseInt(in.nextLine());
        int multiplier = Integer.parseInt(in.nextLine());
        int result = n * multiplier;

        if (multiplier <= 10) {
            for (int i = multiplier; i <= 10; i++) {
                int multiplication = n * i;
                System.out.printf("%d X %d = %d\n", n, i, multiplication);
            }
        } else {
            System.out.printf("%d X %d = %d", n, multiplier, result);
        }
    }
}
