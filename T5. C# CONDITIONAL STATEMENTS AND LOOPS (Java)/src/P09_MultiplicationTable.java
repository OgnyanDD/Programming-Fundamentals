import java.util.Scanner;

public class P09_MultiplicationTable {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int n = Integer.parseInt(in.nextLine());

        for (int i = 1; i <= 10 ; i++) {
            int multiplication = n * i;
            System.out.printf("%d X %d = %d\n", n, i, multiplication);
        }
    }
}
