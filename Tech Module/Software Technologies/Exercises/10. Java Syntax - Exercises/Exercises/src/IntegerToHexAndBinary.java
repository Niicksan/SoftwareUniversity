import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Integer number = Integer.parseInt(scanner.nextLine());

        String hexa = Integer.toHexString(number).toUpperCase();
        String binary = Integer.toBinaryString(number);

        System.out.println(hexa);
        System.out.println(binary);
    }
}