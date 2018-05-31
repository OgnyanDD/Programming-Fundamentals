public class P01_BlankReceipt {
    public static void main(String[] args) {

        PrintReceipt();
    }
    private static void PrintReceiptHeader() {

        System.out.println("CASH RECEIPT");
        System.out.println("------------------------------");
    }
    private static void PrintReceiptBody() {

        System.out.println("Charged to____________________");
        System.out.println("Received by___________________");
    }
    private static void PrintReceiptFooter() {

        System.out.println("------------------------------");
        System.out.println("\u00A9 SoftUni");
    }
    private static void PrintReceipt() {

        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }
}
