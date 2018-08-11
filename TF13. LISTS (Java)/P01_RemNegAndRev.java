import java.util.*;
import java.util.stream.Collectors;

public class P01_RemNegAndRev {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        List<Integer> input = Arrays.stream(in.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        List<Integer> resultList = new ArrayList<>();

        for (int i = 0; i < input.size(); i++) {

            if (input.get(i) > 0) {

                resultList.add(input.get(i));
            }
        }
        Collections.reverse(resultList);

        if (resultList.size() > 0) {

            System.out.println(resultList.toString().replaceAll("[\\[\\],]", ""));

        } else {

            System.out.println("empty");
        }
    }
}