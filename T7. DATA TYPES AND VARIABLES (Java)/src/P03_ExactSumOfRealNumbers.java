import java.math.BigDecimal;
import java.util.Scanner;

public class P03_ExactSumOfRealNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int inputNumber = Integer.parseInt(in.nextLine());
        BigDecimal sum = new BigDecimal(0);

        for (int i = 0; i < inputNumber; i++) {

            BigDecimal number = in.nextBigDecimal();
            sum  = sum.add(number);
        }
        System.out.println(sum);
    }
}
