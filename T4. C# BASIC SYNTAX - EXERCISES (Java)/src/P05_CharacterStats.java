import java.util.Scanner;

public class P05_CharacterStats {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        String name = in.nextLine();
        int currentHealth = Integer.parseInt(in.nextLine());
        int maxHealth = Integer.parseInt(in.nextLine());
        int currentEnergy = Integer.parseInt(in.nextLine());
        int maxEnergy = Integer.parseInt(in.nextLine());

        int remainingHealth = maxHealth - currentHealth;
        int remainingEnergy = maxEnergy - currentEnergy;

        String currentHealthAsString = repeatStr("|", currentHealth);
        String remainingHealthAsString = repeatStr(".", remainingHealth);
        String healthBar = String.format("Health: |%s%s|", currentHealthAsString, remainingHealthAsString);
        String currentEnergyAsString = repeatStr("|", currentEnergy);
        String remainingEnergyAsString = repeatStr(".", remainingEnergy);
        String energyBar = String.format("Energy: |%s%s|", currentEnergyAsString, remainingEnergyAsString);

        System.out.printf("Name: %s\n", name);
        System.out.println(healthBar);
        System.out.println(energyBar);

    }
    static String repeatStr(String text, int count) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++) {
            sb.append(text);
        }
        return sb.toString();
    }
}
