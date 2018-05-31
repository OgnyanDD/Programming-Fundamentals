import java.util.Scanner;

public class P02_MaxMethod {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int a = Integer.parseInt(in.nextLine());
        int b = Integer.parseInt(in.nextLine());
        int c = Integer.parseInt(in.nextLine());

        int max = Math.max(c, GetMax(a, b));
        System.out.println(max);
    }

    private static int GetMax(int a, int b) {

        return Math.max(a, b);
    }
}
