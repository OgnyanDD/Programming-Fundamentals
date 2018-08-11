
import java.util.Scanner;

public class P14_MagicLetter {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        char firstChar = in.nextLine().charAt(0);
        char secondChar = in.nextLine().charAt(0);
        char thirdChar = in.nextLine().charAt(0);

        for (char i = firstChar; i <= secondChar; i++) {
            for (char j = firstChar; j <= secondChar; j++) {
                for (char k = firstChar; k <= secondChar; k++) {

                    if (!(Character.valueOf(i).equals(thirdChar)) && !(Character.valueOf(j).equals(thirdChar)) && !(Character.valueOf(k).equals(thirdChar))) {
                        System.out.printf("%c%c%c ", i, j, k);
                    }
                }
            }
        }
    }
}

