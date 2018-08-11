import java.util.Scanner;

public class P08_CaloriesCounter {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int ingredientsNumber = Integer.parseInt(in.nextLine());
        int calories = 0;
        int totalCalories = 0;

        for (int i = 1; i <= ingredientsNumber ; i++) {

            String ingredient = in.nextLine().toLowerCase();

            switch (ingredient) {
                case "cheese":
                    calories = 500;
                    break;

                case "tomato sauce":
                    calories = 150;
                    break;

                case "salami":
                    calories = 600;
                    break;

                case "pepper":
                    calories = 50;
                    break;
                    default:
                        calories = 0;

            }
            totalCalories += calories;
        }
        System.out.printf("Total calories: %d", totalCalories);
    }
}
