import java.text.DecimalFormat;
import java.util.Scanner;

public class P04_BeverageLabels {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("#.##");

        String name = in.nextLine();
        double volume = Double.parseDouble(in.nextLine());
        double energy = Double.parseDouble(in.nextLine());
        double sugar = Double.parseDouble(in.nextLine());

        double energyVol = (volume * energy) / 100;
        double sugarVol = (volume * sugar) / 100;

        System.out.printf("%.0fml %s:\n", volume, name);
        System.out.println(df.format(energyVol) + "kcal, " + df.format(sugarVol) + "g sugars");
    }
}
