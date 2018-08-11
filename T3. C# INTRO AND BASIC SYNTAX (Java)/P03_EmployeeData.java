import java.util.Scanner;

public class P03_EmployeeData {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String name = in.nextLine();
        int age = Integer.parseInt(in.nextLine());
        int id = Integer.parseInt(in.nextLine());
        double salary = Double.parseDouble(in.nextLine());

        System.out.printf("Name: %s\n", name);
        System.out.printf("Age: %d\n", age);
        System.out.printf("Employee ID: %08d\n", id);
        System.out.printf("Salary: %.2f", salary);
    }
}
