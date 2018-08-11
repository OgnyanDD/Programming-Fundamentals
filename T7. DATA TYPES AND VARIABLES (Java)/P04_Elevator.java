import java.util.Scanner;

public class P04_Elevator {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double peopleNumber = Double.parseDouble(in.nextLine());
        double elevatorCapacity = Double.parseDouble(in.nextLine());

        double result = Math.ceil(peopleNumber / elevatorCapacity);

        System.out.printf("%.0f", result);
    }
}
