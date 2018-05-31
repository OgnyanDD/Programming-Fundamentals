import java.util.Scanner;

public class P03_PrintingTriangle {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int inputNumber = Integer.parseInt(in.nextLine());

        for (int i = 0; i < inputNumber; i++) {
            PrintLine(1, i);
        }

        PrintLine(1, inputNumber);

        for (int j = inputNumber - 1; j >= 0; j--) {
            PrintLine(1, j);
        }
    }

    private static void PrintLine(int start, int end) {
        for (int i = start; i <= end; i++) {

                System.out.print(i + " ");
        }
        System.out.println();
    }
}
