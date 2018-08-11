import java.util.Scanner;

public class P07_Greeting {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String firstName = in.nextLine();
        String lastName = in.nextLine();
        int age = Integer.parseInt(in.nextLine());

        System.out.printf("Hello, %s %s. You are %d years old.", firstName, lastName, age);
    }
}
