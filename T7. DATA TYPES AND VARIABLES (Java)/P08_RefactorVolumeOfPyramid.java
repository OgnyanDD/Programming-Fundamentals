import java.util.Scanner;

public class P08_RefactorVolumeOfPyramid {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        double length, width, height, volume;

        System.out.print("Length: ");
        length = Double.parseDouble(in.nextLine());

        System.out.print("Width: ");
        width = Double.parseDouble(in.nextLine());

        System.out.print("Height: ");
        height = Double.parseDouble(in.nextLine());

        volume = (length * width * height) / 3;

        System.out.printf("Pyramid Volume: %.2f", volume);
    }
}
