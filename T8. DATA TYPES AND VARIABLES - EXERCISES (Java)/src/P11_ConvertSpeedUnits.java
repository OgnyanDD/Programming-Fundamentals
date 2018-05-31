import java.text.DecimalFormat;
import java.util.Scanner;

public class P11_ConvertSpeedUnits {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        float distance = Float.parseFloat(in.nextLine());
        float hours = Float.parseFloat(in.nextLine());
        float minutes = Float.parseFloat(in.nextLine());
        float seconds = Float.parseFloat(in.nextLine());

        float hourTime = hours + (minutes / 60.0f) + (seconds / 3600.0f);
        float kmSpeed = (distance / 1000.0f) / hourTime;
        float metersSpeed = (kmSpeed / 3.6f);
        float milesSpeed = (distance / 1609.0f) / hourTime;

        DecimalFormat df = new DecimalFormat("#.######");

        System.out.println(df.format(metersSpeed));
        System.out.println(df.format(kmSpeed));
        System.out.println(df.format(milesSpeed));
    }
}
