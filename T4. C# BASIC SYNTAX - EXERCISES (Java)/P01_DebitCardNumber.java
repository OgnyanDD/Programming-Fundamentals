import java.util.Scanner;

public class P01_DebitCardNumber {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int a = Integer.parseInt(in.nextLine());
        int b = Integer.parseInt(in.nextLine());
        int c = Integer.parseInt(in.nextLine());
        int d = Integer.parseInt(in.nextLine());

        System.out.printf("%04d %04d %04d %04d", a, b, c, d);
    }
}
