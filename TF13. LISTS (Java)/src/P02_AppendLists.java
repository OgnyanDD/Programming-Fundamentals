import java.util.*;
import java.util.stream.Collectors;

public class P02_AppendLists {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<String> input = Arrays.stream(in.nextLine().split("\\|")).collect(Collectors.toList());
        List<String> result = new ArrayList<>();

        Collections.reverse(input);

        for (String text : input) {

            String[] splitted = text.split(" ");
            String merged = String.join(" ", removedNull(splitted));

            result.add(merged);
        }
        for (String finish : result) {
            System.out.print(finish + " ");
        }
    }

    private static String[] removedNull(String[] arr) { //  REMOVE NULL ELEMENTS FROM ARRAY!

        String[] removedNull = Arrays.stream(arr)
                .filter(value -> value != null && value.length() > 0)
                .toArray(String[]::new);

        return removedNull;
    }
}
