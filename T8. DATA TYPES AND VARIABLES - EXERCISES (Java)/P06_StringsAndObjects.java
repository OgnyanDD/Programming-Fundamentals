
public class P06_StringsAndObjects {
    public static void main(String[] args) {

        String word1 = "Hello";
        String word2 = "World";

        Object sumWords = word1 + " " + word2;

        String finalResult = String.valueOf(sumWords);

        System.out.println(finalResult);
    }
}
