import java.util.*;
import java.util.stream.Collectors;

public class P06_SquareNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Integer> input = Arrays.stream(in.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        List<Integer> result= new ArrayList<>();

        for (int digit: input) {

            if (Math.sqrt(digit) == (int)Math.sqrt(digit)) {

                result.add(digit);
            }
        }

        Collections.sort(result);
        Collections.reverse(result);

        for (int print: result) {

            System.out.printf("%d ", print);
        }
    }
}
