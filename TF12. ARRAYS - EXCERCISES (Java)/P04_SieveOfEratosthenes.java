import java.util.Scanner;

public class P04_SieveOfEratosthenes {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int inputNumber = Integer.parseInt(in.nextLine());

        SieveOfEratosthenes(inputNumber);
    }

    private static void SieveOfEratosthenes(int n) {
        boolean[] array = new boolean[n + 1];

        for (int i = 0; i <= n; i++)
        {
            array[i] = true;
        }
        array[0] = false;
        array[1] = false;

        for (int i = 0; i < array.length; i++)
        {
            if (array[i])
            {
                for (int a = 2; (a * i) <= n; a++)
                {
                    array[a * i] = false;
                }
            }
        }
        for (int j = 2; j <= n; j++)
        {
            if (array[j])
            {
                System.out.print(j + " ");
            }
        }
        System.out.println();
    }
}
