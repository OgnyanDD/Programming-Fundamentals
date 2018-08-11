import java.util.Scanner;

public class P10_CubeProperties {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double inputNumber = Double.parseDouble(in.nextLine());
        String cubeProperties = in.nextLine();
        double result;

        switch (cubeProperties)

        {
            case "face":

                result = GetFaceDiagonalsLenght(inputNumber);
                System.out.printf("%.2f", result);
                break;

            case "space":

                result = GetSpaceDiagonalsLenght(inputNumber);
                System.out.printf("%.2f", result);
                break;

            case "volume":

                result = GetVolume(inputNumber);
                System.out.printf("%.2f", result);
                break;

            case "area":

                result = GetSurfaceArea(inputNumber);
                System.out.printf("%.2f", result);
                break;
        }
    }

    private static double GetFaceDiagonalsLenght(double n) {
        return Math.sqrt(2 * Math.pow(n, 2));
    }

    private static double GetSpaceDiagonalsLenght(double n) {
        return Math.sqrt(3 * Math.pow(n, 2));
    }

    private static double GetVolume(double n) {
        return Math.pow(n, 3);
    }

    private static double GetSurfaceArea(double n) {
        return 6 * Math.pow(n, 2);
    }
}

