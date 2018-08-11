import java.text.DecimalFormat;
import java.util.Scanner;

public class P11_PriceChangeAlert {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int prices = Integer.parseInt(in.nextLine());
        double threshold = Double.parseDouble(in.nextLine());
        double lastPrice = Double.parseDouble(in.nextLine());

        for (int i = 0; i < prices - 1; i++) {

            double currentPrice = Double.parseDouble(in.nextLine());
            double priceDiff = PriceDiff(lastPrice, currentPrice);
            boolean isSignificantDifference = IsSignificantDifference(priceDiff, threshold);
            String message = GetChangeEffectAsString(currentPrice, lastPrice, priceDiff, isSignificantDifference);

            System.out.println(message);

            lastPrice = currentPrice;
        }
    }

    private static String GetChangeEffectAsString(double currentPrice, double lastPrice, double priceDiff, boolean isSignificantDifference) {
        DecimalFormat df = new DecimalFormat("#.####");
        DecimalFormat db = new DecimalFormat("#,####0.00");

        String to = "";

        if (priceDiff == 0) {

            to = "NO CHANGE: " + df.format(currentPrice);

        } else if (!isSignificantDifference) {

            to = "MINOR CHANGE: " + df.format(lastPrice) + " to " + df.format(currentPrice) + " (" + db.format(priceDiff * 100.0d) + "%" + ")";
        } else if (isSignificantDifference && (priceDiff > 0)) {
            to = "PRICE UP: " + df.format(lastPrice) + " to " + df.format(currentPrice) + " (" + db.format(priceDiff * 100.0d) + "%" + ")";
        } else if (isSignificantDifference && (priceDiff < 0)) {
            to = "PRICE DOWN: " + df.format(lastPrice) + " to " + df.format(currentPrice) + " (" + db.format(priceDiff * 100.0d) + "%" + ")";
        }

        return to;
    }

    static boolean IsSignificantDifference(double priceDiff, double threshold) {
        if (Math.abs(priceDiff) >= threshold) {
            return true;
        }

        return false;
    }

    static double PriceDiff(double lastPrice, double currentPrice) {
        return (currentPrice - lastPrice) / lastPrice;
    }
}

