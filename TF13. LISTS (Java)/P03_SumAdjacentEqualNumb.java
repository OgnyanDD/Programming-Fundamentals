import java.text.DecimalFormat;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P03_SumAdjacentEqualNumb {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Double> numbers = Arrays.stream(in.nextLine().split(" "))
                .map(Double::parseDouble)
                .collect(Collectors.toList());

        double sum = 0;
        int index = 1;

        while (index < numbers.size()) {
            if (numbers.get(index - 1).equals(numbers.get(index))) {
                sum = numbers.get(index - 1) + numbers.get(index);
                numbers.remove(index - 1);
                numbers.remove(index - 1);
                numbers.add(index - 1, sum);
                if (index > 1) {
                    index--;
                }
            } else {
                index++;
            }
        }
        DecimalFormat df = new DecimalFormat("#.##");

        for (double result : numbers) {
            System.out.print(df.format(result) + " ");
        }
    }
}
