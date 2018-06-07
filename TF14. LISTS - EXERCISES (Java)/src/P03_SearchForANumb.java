import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P03_SearchForANumb {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Integer> input = Arrays.stream(in.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int[] arr = Arrays.stream(in.nextLine().split(" "))
                .map(String::trim).mapToInt(Integer::parseInt).toArray();

        List<Integer> newList = new ArrayList<>();

        int numbTake = arr[0];
        int numbDelete = arr[1];
        int numbCheck = arr[2];

        for (int i = 0; i < numbTake; i++) {

            newList.add(input.get(i));
        }

        for (int i = 0; i < numbDelete; i++) {

            newList.remove(0);
        }

        for (int i = 0; i < numbCheck; i++) {

            if (newList.contains(numbCheck)) {

                System.out.println("YES!");
                break;
            } else {

                System.out.println("NO!");
                break;
            }
        }
    }
}
