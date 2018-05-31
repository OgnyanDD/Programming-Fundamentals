import java.util.Scanner;

public class P03_EnNameOfLastDigit {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        long input = Long.parseLong(in.nextLine());

        DigitToWord(Math.abs(input));
    }

    private static void DigitToWord(long n) {
        long lastDigit = n % 10;
        String word = "";
        String[] digitValue = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for (int i = 0; i <= lastDigit; i++) {

            if (lastDigit == i) {
                word = digitValue[i];
            }
        }
        System.out.println(word);
    }
}
