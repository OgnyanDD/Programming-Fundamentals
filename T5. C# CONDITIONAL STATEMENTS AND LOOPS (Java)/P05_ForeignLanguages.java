import java.util.Scanner;

public class P05_ForeignLanguages {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        String countryInput = in.nextLine();

        if (countryInput.equals("USA") || countryInput.equals("England"))
        {
            System.out.println("English");
        }
        else if(countryInput.equals("Spain") || countryInput.equals("Argentina") || countryInput.equals("Mexico"))
        {
            System.out.println("Spanish");
        }
        else
        {
            System.out.println("unknown");
        }
    }
}
