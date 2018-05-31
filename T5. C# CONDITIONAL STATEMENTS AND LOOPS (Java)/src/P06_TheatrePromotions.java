import java.util.Scanner;

public class P06_TheatrePromotions {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        String dayType = in.nextLine().toLowerCase();
        int age = Integer.parseInt(in.nextLine());

        if (dayType.equals("weekday")) {
            if (age >= 0 && age <= 18 || age > 64 && age <= 122) {
                System.out.println("12$");
            } else if (age > 18 && age <= 64) {
                System.out.println("18$");
            } else {
                System.out.println("Error!");
            }
        } else if (dayType.equals("weekend")) {
            if (age >= 0 && age <= 18 || age > 64 && age <= 122) {
                System.out.println("15$");
            } else if (age > 18 && age <= 64) {
                System.out.println("20$");
            } else {
                System.out.println("Error!");
            }
        } else if (dayType.equals("holiday")) {
            if (age >= 0 && age <= 18) {
                System.out.println("5$");
            } else if (age > 18 && age <= 64) {
                System.out.println("12$");
            } else if (age > 64 && age <= 122) {
                System.out.println("10$");
            } else {
                System.out.println("Error!");
            }
        }
    }
}
