import java.util.Scanner;

public class P03_BackIn30Minutes {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int hoursInput = Integer.parseInt(in.nextLine());
        int minutesInput = Integer.parseInt(in.nextLine());
        final int REST = 30;
        final int MINUTES = 60;
        final int HOURS = 24;

        if (minutesInput + REST > MINUTES - 1){
            hoursInput++;
            minutesInput += REST - MINUTES;
        } else {
            minutesInput += REST;
        }
        if (hoursInput > HOURS - 1) {
            hoursInput -= HOURS;
        }
        System.out.printf("%d:%02d", hoursInput, minutesInput);
    }
}
