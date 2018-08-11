import java.util.Scanner;

public class P15_NeighbourWars {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int damagePesho = Integer.parseInt(in.nextLine());
        int damageGosho = Integer.parseInt(in.nextLine());

        final int HEALTH_POINTS = 10;
        int bloodPesho = 100;
        int bloodGosho = 100;
        int rounds = 1;


        while (true) {

            if (rounds % 2 != 0) {

                bloodGosho -= damagePesho;
                if (bloodGosho <= 0) {

                    System.out.printf("Pesho won in %dth round.", rounds);
                    break;
                } else {

                    System.out.printf("Pesho used Roundhouse kick and reduced Gosho to %d health.\n", bloodGosho);
                }
            } else {

                bloodPesho -= damageGosho;

                if (bloodPesho <= 0) {

                    System.out.printf("Gosho won in %dth round.", rounds);
                    break;
                } else {

                    System.out.printf("Gosho used Thunderous fist and reduced Pesho to %d health.\n", bloodPesho);
                }
            }
            if (rounds % 3 == 0) {

                bloodGosho += HEALTH_POINTS;
                bloodPesho += HEALTH_POINTS;
            }
            rounds++;
        }
    }
}
