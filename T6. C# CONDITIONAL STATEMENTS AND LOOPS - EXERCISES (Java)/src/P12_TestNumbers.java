import java.util.Scanner;

public class P12_TestNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int n = Integer.parseInt(in.nextLine());
        int m = Integer.parseInt(in.nextLine());
        int sumBoundary = Integer.parseInt(in.nextLine());

        int sum = 0;
        int counter = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                if (sum >= sumBoundary)
                {
                    break;
                }

                counter++;
                sum += 3 * (i * j);
            }
        }
        if (sum >= sumBoundary)
        {
            System.out.printf("%d combinations\n", counter);
            System.out.printf("Sum: %d >= %d", sum, sumBoundary);
        }
        else
        {
            System.out.printf("%d combinations\n", counter);
            System.out.printf("Sum: %d", sum);
        }
    }
}
