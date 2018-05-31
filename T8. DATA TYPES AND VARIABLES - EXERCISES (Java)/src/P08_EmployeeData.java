import java.util.Scanner;

public class P08_EmployeeData {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String firstName = in.nextLine();
        String lastName = in.nextLine();
        int age = Integer.parseInt(in.nextLine());
        char gender = in.nextLine().charAt(0);
        long idNumber = Long.parseLong(in.nextLine());
        int personalNumber = Integer.parseInt(in.nextLine());

        System.out.printf("First name: %s\n", firstName);
        System.out.printf("Last name: %s\n", lastName);
        System.out.printf("Age: %d\n", age);
        System.out.printf("Gender: %c\n", gender);
        System.out.printf("Personal ID: %d\n", idNumber);
        System.out.printf("Unique Employee number: %d", personalNumber);
    }
}
