import java.util.Scanner;

public class P02_ChooseADrink_2 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        String profession = in.nextLine();
        int quantitie = Integer.parseInt(in.nextLine());
        double price;

        if (profession.equals("Athlete")) {
            price = 0.70;
            System.out.printf("The %s has to pay %.2f.", profession, quantitie * price);
        } else if (profession.equals("Businessman") || profession.equals("Businesswoman")) {
            price = 1.00;
            System.out.printf("The %s has to pay %.2f.", profession, quantitie * price);
        } else if (profession.equals("SoftUni Student")) {
            price = 1.70;
            System.out.printf("The %s has to pay %.2f.", profession, quantitie * price);
        } else {
            price = 1.20;
            System.out.printf("The %s has to pay %.2f.", profession, quantitie * price);
        }
    }
}
