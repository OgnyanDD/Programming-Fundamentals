import java.util.ArrayList;
import java.util.Scanner;


public class P07_BombNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        ArrayList<Integer> numbers = InputTolist(in.nextLine().split("\\s"));

        int bomb = in.nextInt();
        int power = in.nextInt();

        while (numbers.indexOf(bomb) >= 0) {
            Explode(numbers, bomb, power);
        }

        System.out.println(Sum(numbers));
    }

    private static int Sum(ArrayList<Integer> numbers) {
        int sum = 0;

        for (Integer number : numbers) {
            sum += number;
        }

        return sum;
    }

    private static void Explode(ArrayList<Integer> numbers, int bomb, int power) {
        int bombIndex = numbers.indexOf(bomb);
        int removalIndex = bombIndex - power;
        int deletionsCount = power * 2 + 1;

        if (removalIndex < 0) {
            deletionsCount += removalIndex;
            removalIndex = 0;
        }

        while (deletionsCount > 0 && removalIndex < numbers.size()) {
            numbers.remove(removalIndex);
            deletionsCount--;
        }
    }

    private static ArrayList<Integer> InputTolist(String[] strings) {
        ArrayList<Integer> numbers = new ArrayList<Integer>();

        for (String string : strings) {
            numbers.add(Integer.parseInt(string));
        }

        return numbers;
    }
}
