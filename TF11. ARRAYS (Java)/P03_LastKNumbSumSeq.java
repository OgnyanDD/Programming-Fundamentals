import java.util.Scanner;

public class P03_LastKNumbSumSeq {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int n = Integer.parseInt(in.nextLine());
        int k = Integer.parseInt(in.nextLine());
        long [] nums = new long[n];
        nums[0] = 1;

        for (int i = 1; i < n; i++)
        {
            long sum = 0;

            for (int j = i - k; j <= i - 1; j++)
            {
                if (j >= 0)
                {
                    sum += nums[j];
                }
            }
            nums[i] = sum;
        }
        for (int i = 0; i < n; i++)
        {
            System.out.printf("%d ", nums[i]);
        }
        System.out.println();
    }
}
