import java.util.Scanner;

public class P11_5DifferentNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int a = Integer.parseInt(in.nextLine());
        int b = Integer.parseInt(in.nextLine());

        if (Math.abs(a - b) < 5) {
            System.out.println("No");
        } else {
            for (int i = a; i <= b; i++) {
                for (int j = a; j <= b; j++) {
                    for (int k = a; k <= b; k++) {
                        for (int l = a; l <= b; l++) {
                            for (int m = a; m <= b; m++) {

                                if (j <= i || k <= j || l <= k || m <= l) {
                                    continue;
                                } else {
                                    System.out.printf("%d %d %d %d %d\n", i, j, k, l, m);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
