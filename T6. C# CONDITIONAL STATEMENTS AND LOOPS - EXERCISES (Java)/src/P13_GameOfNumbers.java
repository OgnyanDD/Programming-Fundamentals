import java.util.Scanner;

public class P13_GameOfNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int n = Integer.parseInt(in.nextLine());
        int m = Integer.parseInt(in.nextLine());
        int magicNumber = Integer.parseInt(in.nextLine());

        int sum = 0;
        int counter = 0;
        int counterMatch = 0;


        for (int i = m; i >= n; i--)
        {
            for (int j = m; j >= n; j--)
            {

                sum = i + j;
                counter++;

                if (sum == magicNumber)
                {

                    System.out.printf("Number found! %d + %d = %d", i, j, magicNumber);
                    counterMatch++;
                    return;
                }
            }
        }

        if (counterMatch == 0)
        {

            System.out.printf("%d combinations - neither equals %d", counter, magicNumber);
        }
    }
}
