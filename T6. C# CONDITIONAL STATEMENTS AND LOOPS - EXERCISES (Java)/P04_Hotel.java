import java.util.Scanner;

public class P04_Hotel {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        double priceStudio = 0;
        double priceDouble = 0;
        double priceSuite = 0;

        String month = in.nextLine();
        int nights = Integer.parseInt(in.nextLine());

        switch (month) {
            case "May":
            case "October":
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;
                break;

            case "June":
            case "September":
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;
                break;

            case "July":
            case "August":
            case "December":
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;
                break;
        }

        if ((month.equals("May") || month.equals("October")) && nights > 7) {
            priceStudio *= 0.95;
        } else if ((month.equals("June") || month.equals("September")) && nights > 14) {
            priceDouble *= 0.9;
        } else if ((month.equals("July") || month.equals("August") || month.equals("December")) && nights > 14) {
            priceSuite *= 0.85;
        }

        double endPriceStudio = priceStudio * nights;
        double endPriceDouble = priceDouble * nights;
        double endPriceSuite = priceSuite * nights;

        if ((month.equals("September") || month.equals("October")) && nights > 7) {
            endPriceStudio -= priceStudio;
        }

        System.out.printf("Studio: %.2f lv.\n", endPriceStudio);
        System.out.printf("Double: %.2f lv.\n", endPriceDouble);
        System.out.printf("Suite: %.2f lv.", endPriceSuite);
    }
}
