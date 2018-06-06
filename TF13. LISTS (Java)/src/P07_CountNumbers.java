import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P07_CountNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Integer> input = Arrays.stream(in.nextLine().split(" "))
                .map(Integer::parseInt).sorted().collect(Collectors.toList());

        int count = 1;

        for (int i = 1; i < input.size(); i++) {
            if (input.get(i - 1).equals(input.get(i))) {
                count++;
            } else {
                System.out.println(input.get(i - 1) + " -> " + count);
                count = 1;
            }
        }
        System.out.println(input.get(input.size() - 1) + " -> " + count);
    }
}
