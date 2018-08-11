import java.util.Scanner;

public class P14_IntegerToHexAndBinary {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int input = Integer.parseInt(in.nextLine());

        String toHex = Integer.toString(input, 16).toUpperCase();
        String toBin = Integer.toString(input, 2).toUpperCase();

        System.out.println(toHex);
        System.out.println(toBin);
    }
}
