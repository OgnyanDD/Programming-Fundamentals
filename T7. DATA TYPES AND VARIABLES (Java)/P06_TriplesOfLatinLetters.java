import java.util.Scanner;

public class P06_TriplesOfLatinLetters {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = in.nextInt() + 'a';

        for (char i = 'a'; i < input; i++) {
            for (char j = 'a'; j < input; j++) {
                for (char k = 'a'; k < input; k++) {
                    System.out.printf("%c%c%c \n", i, j, k);
                }
            }
        }
    }
}
