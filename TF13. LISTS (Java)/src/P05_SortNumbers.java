import java.text.DecimalFormat;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P05_SortNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Double> input = Arrays.stream(in.nextLine().split(" "))
                .map(Double::parseDouble).sorted().collect(Collectors.toList());

        DecimalFormat df = new DecimalFormat("#.##");

        for (int i = 0; i < input.size(); i++) {

            if (i == 0) {
                System.out.print(df.format(input.get(i)));
            } else {
                System.out.print(" <= " + df.format(input.get(i)));
            }
        }
    }
}
