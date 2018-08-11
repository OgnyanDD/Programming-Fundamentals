import java.util.Scanner;

public class P13_VowelOrDigit {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        char input = in.nextLine().charAt(0);

        if (input == 'a' || input == 'e' || input == 'o' || input == 'u' || input == 'i') {
            System.out.println("vowel");
        } else if (Character.isDigit(input)) {
            System.out.println("digit");
        } else {
            System.out.println("other");
        }
    }
}
