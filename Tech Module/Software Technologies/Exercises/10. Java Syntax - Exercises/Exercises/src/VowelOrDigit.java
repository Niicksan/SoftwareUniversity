import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine().toLowerCase();

        String letter = "";
        switch (input) {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                letter = "vowel";
                break;
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                letter = "digit";
                break;
            default:
                letter = "other";
                break;
        }

        System.out.print(letter);
    }
}
