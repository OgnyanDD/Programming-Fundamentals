import java.util.Scanner;

public class P08_GreaterOfTwoValues {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String input = in.nextLine();

        switch (input) {
            case "int": {

                int a = Integer.parseInt(in.nextLine());
                int b = Integer.parseInt(in.nextLine());

                System.out.println(TypeInt(a, b));

                break;
            }
            case "char": {

                char a = in.nextLine().charAt(0);
                char b = in.nextLine().charAt(0);

                System.out.println(TypeChar(a, b));

                break;
            }
            case "string": {
                String a = in.nextLine();
                String b = in.nextLine();

                System.out.println(TypeString(a, b));
                break;
            }
        }

    }

    private static int TypeInt(int a, int b) {
        if (a >= b) {
            return (a);
        } else {
            return (b);
        }
    }

    private static char TypeChar(char a, char b) {
        if (a >= b) {
            return (a);
        } else {
            return (b);
        }
    }

    private static String TypeString(String a, String b) {
        if (a.compareTo(b) >= 0) {
            return (a);
        } else {
            return (b);
        }
    }
}
