import java.util.Scanner;

public class P19_TheaThePhotographer {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        long n = Long.parseLong(in.nextLine());
        long filterTime = Long.parseLong(in.nextLine());
        long filterFactor = Long.parseLong(in.nextLine());
        long uploadTime = Long.parseLong(in.nextLine());

        long totalFilteringTime = n * filterTime;
        long goodPictures = (long) (Math.ceil(n * filterFactor / 100d));
        long totalUploadTime = goodPictures * uploadTime;
        long totalTime = totalFilteringTime + totalUploadTime;

        if (totalTime > 59) {
            long minutes = totalTime / 60;
            long seconds = totalTime % 60;

            if (minutes > 59) {
                long hours = minutes / 60;
                minutes = minutes % 60;

                if (hours > 23) {
                    long days = hours / 24;
                    hours = hours % 24;

                    System.out.printf("%d:%02d:%02d:%02d", days, hours, minutes, seconds);
                } else {
                    System.out.printf("0:%02d:%02d:%02d", hours, minutes, seconds);
                }
            } else {
                System.out.printf("0:00:%02d:%02d", minutes, seconds);
            }
        } else {
            System.out.printf("0:00:00:%02d", totalTime);
        }
    }
}
