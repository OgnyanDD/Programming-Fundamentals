import java.util.Scanner;

public class P03_RestaurantDiscount {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int groupSize = Integer.parseInt(in.nextLine());;
        String packageType = in.nextLine();
        int priceHall;
        int pricePackage;
        int totalPrice;
        double discount;
        double totalPriceWithDiscount;
        double pricePerPerson;

        if (groupSize <= 50)
        {
            priceHall = 2500;
            switch (packageType)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 0.05;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Small Hall\nThe price per person is %.2f$", pricePerPerson);
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 0.10;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Small Hall\nThe price per person is %.2f$", pricePerPerson);
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 0.15;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Small Hall\nThe price per person is %.2f$", pricePerPerson);
                    break;
            }
        }
        else if (groupSize > 50 && groupSize <= 100)
        {
            priceHall = 5000;
            switch (packageType)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 0.05;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Terrace\nThe price per person is %.2f$", pricePerPerson);
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 0.10;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Terrace\nThe price per person is %.2f$", pricePerPerson);
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 0.15;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Terrace\nThe price per person is %.2f$", pricePerPerson);
                    break;
            }
        }
        else if (groupSize > 100 && groupSize <= 120)
        {
            priceHall = 7500;
            switch (packageType)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 0.05;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Great Hall\nThe price per person is %.2f$", pricePerPerson);
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 0.10;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Great Hall\nThe price per person is %.2f$", pricePerPerson);
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 0.15;
                    totalPrice = priceHall + pricePackage;
                    totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                    pricePerPerson = totalPriceWithDiscount / groupSize;
                    System.out.printf("We can offer you the Great Hall\nThe price per person is %.2f$", pricePerPerson);
                    break;
            }
        }
        else
        {
            System.out.println("We do not have an appropriate hall.");
        }
    }
}
