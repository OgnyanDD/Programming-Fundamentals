public class P07_ExchangeVariableValues {
    public static void main(String[] args) {

        int a = 5;
        int b = 10;

        System.out.printf("Before:\na = %d\nb = %d\n", a, b);

        int c = a;
        a = b;
        b = c;

        System.out.printf("After:\na = %d\nb = %d", a, b);
    }
}
