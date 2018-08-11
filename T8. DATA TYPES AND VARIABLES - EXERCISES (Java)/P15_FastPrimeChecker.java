import java.util.Scanner;

public class P15_FastPrimeChecker {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int num = Integer.parseInt(in.nextLine());

        for (int curNum = 2; curNum <= num; curNum++) {
            boolean isPrime = true;
            for (int devider = 2; devider <= Math.sqrt(curNum); devider++) {

                if (curNum % devider == 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                System.out.printf("%d -> True\n", curNum);
            } else {
                System.out.printf("%d -> False\n", curNum);
            }
        }
    }
}
