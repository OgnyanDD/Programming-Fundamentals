import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class P05_ArrayManipulator {
    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        List<Integer> nums= Arrays.stream(br.readLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        while (true)
        {
            String line = br.readLine();

            if (line.equals("print"))
            {
                System.out.println(nums);
                break;
            }

            String[] tokens = line.split(" ");

            String command = tokens[0];

            int index;
            int element;

            switch (command)
            {
                case "add":

                    index = Integer.parseInt(tokens[1]);
                    element = Integer.parseInt(tokens[2]);
                    nums.add(index, element);
                    break;

                case "addMany":

                    addMany(nums, tokens);
                    break;

                case "contains":

                    element = Integer.parseInt(tokens[1]);
                    index = nums.indexOf(element);
                    System.out.println(index);
                    break;

                case "remove":

                    index = Integer.parseInt(tokens[1]);
                    nums.remove(index);
                    break;

                case "shift":

                    int rotations = Integer.parseInt(tokens[1]);
                    Shift(nums, rotations);
                    break;

                case "sumPairs":

                    SumPairs(nums);
                    break;
            }
        }
    }

    private static void SumPairs(List<Integer> nums)
    {
        for (int i = 0; i < nums.size() - 1; i++)
        {
            nums.set(i, nums.get(i) + nums.get(i + 1));
            nums.remove(i + 1);
        }
    }

    private static void Shift(List<Integer> nums, int rotations)
    {
        for (int i = 0; i < rotations % nums.size(); i++)
        {
            int first = nums.get(0);
            nums.remove(0);
            nums.add(first);
        }
    }

    private static void addMany(List<Integer> nums, String[] tokens)
    {
        int index = Integer.parseInt(tokens[1]);
        List<Integer> numbersToAdd = new ArrayList<>();

        for (int i = 2; i < tokens.length; i++)
        {
            numbersToAdd.add(Integer.parseInt(tokens[i]));
        }
        nums.addAll(index, numbersToAdd);
    }
}