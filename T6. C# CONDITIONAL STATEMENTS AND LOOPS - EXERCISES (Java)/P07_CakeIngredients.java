import java.util.Scanner;

public class P07_CakeIngredients {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int counter = 0;

        while (true) {

            String input = in.nextLine();

            if (!(input.equals("Bake!"))) {
                System.out.printf("Adding ingredient %s.\n", input);
            } else {
                System.out.printf("Preparing cake with %d ingredients.", counter);
                break;
            }
            counter ++;
        }
    }
}
