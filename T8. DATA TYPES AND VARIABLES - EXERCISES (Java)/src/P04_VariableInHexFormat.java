import java.util.Scanner;

public class P04_VariableInHexFormat {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String input = in.nextLine();
        long number = Long.decode(input);

        System.out.println(Long.parseLong(String.valueOf(number)));
    }
}
