import java.util.Scanner;

public class P09_IndexOfLetters {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String word = in.nextLine().toLowerCase();
        char[] letters = word.toCharArray();

        for (char letter : letters) {

            System.out.printf("%c -> %d\n", letter, letter - 'a');
        }
    }
}
