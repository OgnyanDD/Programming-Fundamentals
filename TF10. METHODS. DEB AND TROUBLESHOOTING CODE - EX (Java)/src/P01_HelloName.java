import java.util.Scanner;

public class P01_HelloName {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String input = in.nextLine();

        System.out.printf("Hello, %s!", NameMethod(input));
    }

    private static String NameMethod(String name) {
        return name;
    }
}
