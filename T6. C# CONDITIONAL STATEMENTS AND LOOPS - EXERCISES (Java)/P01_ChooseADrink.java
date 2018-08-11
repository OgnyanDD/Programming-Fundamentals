import java.util.Scanner;

public class P01_ChooseADrink {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        String profession = in.nextLine();

        if (profession.equals("Athlete")) {
            System.out.println("Water");
        } else if (profession.equals("Businessman") || profession.equals("Businesswoman")) {
            System.out.println("Coffee");
        } else if (profession.equals("SoftUni Student")) {
            System.out.println("Beer");
        } else {
            System.out.println("Tea");
        }
    }
}
