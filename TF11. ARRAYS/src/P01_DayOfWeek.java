import java.util.Scanner;

public class P01_DayOfWeek {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int inputDayNumber = Integer.parseInt(in.nextLine());

        String result = getDayOfWeek(inputDayNumber);

        System.out.println(result);
    }

    private static String getDayOfWeek(int inputDayNumber) {

        String[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        if (inputDayNumber >= 1 && inputDayNumber <= 7) {
            return daysOfWeek[inputDayNumber - 1];
        } else {
            return "Invalid Day!";
        }
    }
}
