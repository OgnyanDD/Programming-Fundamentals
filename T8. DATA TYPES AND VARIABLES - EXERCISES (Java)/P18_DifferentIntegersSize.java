import java.util.Scanner;

public class P18_DifferentIntegersSize {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String input = in.nextLine();
        String result = "";

        try {
            byte a = Byte.parseByte(input);
            result += "* byte\n";
        } catch (Exception ex) {
        }
        try {
            short b = Short.parseShort(input);
            result += "* short\n";
        } catch (Exception ex) {
        }
        try {
            int c = Integer.parseInt(input);
            result += "* int\n";
        } catch (Exception ex) {
        }
        try {
            long d = Long.parseLong(input);
            result += "* long";
        } catch (Exception ex) {
        }

        if (result.length() != 0) {
            System.out.println(input + " can fit in:");
            System.out.print(result);
        } else {
            System.out.println(input + " can't fit in any type");
        }
    }
}
