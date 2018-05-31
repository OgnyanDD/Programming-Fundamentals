import java.util.Scanner;

public class P10_TriangleOfNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int number = Integer.parseInt(in.nextLine());

        for (int i = 1; i <= number ; i++) {
            for (int j = 1; j <= i ; j++) {

                if (j == i) {

                    System.out.print(i);

                } else {

                    System.out.print(i + " ");
                }
            }

            System.out.println();
        }
    }
}
