import java.util.Scanner;

public class P09_ReversedChars {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        char firstCh = in.nextLine().charAt(0);
        char secondCh = in.nextLine().charAt(0);
        char thirdCh = in.nextLine().charAt(0);

        System.out.printf("%c%c%c", thirdCh, secondCh, firstCh);
    }
}
