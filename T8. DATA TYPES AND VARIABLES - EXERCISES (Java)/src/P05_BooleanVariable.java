import java.util.Scanner;

public class P05_BooleanVariable {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String input = in.nextLine();

        boolean isTrue = Boolean.valueOf(input);

        if (isTrue) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
