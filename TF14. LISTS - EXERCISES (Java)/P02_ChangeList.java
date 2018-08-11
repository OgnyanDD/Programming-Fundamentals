import java.io.Console;
import java.util.*;
import java.util.stream.Collectors;

public class P02_ChangeList {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Integer> input = Arrays.stream(in.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        while (true) {
            String[] command = in.nextLine().split(" ");

            if (command[0].equals("Delete")) {

                int removed = Integer.parseInt(command[1]);

                input.removeAll(Collections.singleton(removed));

            } else if (command[0].equals("Insert")) {

                input.add(Integer.parseInt(command[2]), Integer.parseInt(command[1]));

            } else if (command[0].equals("Even")) {

                for (Integer anInput : input) {

                    if (anInput % 2 == 0) {

                        System.out.printf("%d ", anInput);
                    }
                }
                System.out.println();
                break;

            } else if (command[0].equals("Odd")) {

                for (Integer anInput : input) {

                    if (anInput % 2 != 0) {

                        System.out.printf("%d ", anInput);
                    }
                }
                System.out.println();
                break;
            }
        }
    }
}
