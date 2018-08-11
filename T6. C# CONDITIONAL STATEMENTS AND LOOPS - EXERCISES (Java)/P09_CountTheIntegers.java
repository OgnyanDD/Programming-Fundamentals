import java.util.Scanner;

public class P09_CountTheIntegers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int counter = 0;

        while (true) {

            try {

                int input = Integer.parseInt(in.nextLine());

            } catch (NumberFormatException exception) {

                System.out.println(counter);
                break;
            }
            counter++;
        }
    }
}
