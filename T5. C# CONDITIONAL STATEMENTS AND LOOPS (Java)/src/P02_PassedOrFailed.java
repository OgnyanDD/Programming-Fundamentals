import java.util.Scanner;

public class P02_PassedOrFailed {
    public static void main(String[] args) {
        Scanner in = new Scanner (System.in);

        double grade = Double.parseDouble(in.nextLine());

        if (grade >= 3.00){
            System.out.println("Passed!");
        } else {
            System.out.println("Failed!");
        }
    }
}
