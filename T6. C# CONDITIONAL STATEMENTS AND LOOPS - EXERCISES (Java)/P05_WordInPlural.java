import java.util.Scanner;

public class P05_WordInPlural {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        String word = in.nextLine();

        if (word.endsWith("y")) {

            StringBuilder dell = new StringBuilder(word);
            dell.deleteCharAt(word.length() - 1);
            System.out.println(dell + "ies");

        } else if (word.endsWith("o") ||
                word.endsWith("ch") ||
                word.endsWith("s") ||
                word.endsWith("sh") ||
                word.endsWith("x") ||
                word.endsWith("z")) {

            System.out.println(word + "es");
        } else {

            System.out.println(word + "s");
        }
    }
}
