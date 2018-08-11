import java.util.Scanner;

public class P17_PrintPartOfASCIITable {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int firstDigit = Integer.parseInt(in.nextLine());
        int secondDigit = Integer.parseInt(in.nextLine());

        for (int i = firstDigit; i <= secondDigit ; i++) {
            if (i < secondDigit) {
                System.out.print((char)i + " ");
            } else {
                System.out.println((char)i);
            }
        }
        System.out.println();
    }
}
