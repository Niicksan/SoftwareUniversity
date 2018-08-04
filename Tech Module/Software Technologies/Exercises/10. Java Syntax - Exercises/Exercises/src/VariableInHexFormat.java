import java.util.Scanner;

public class VariableInHexFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String hexa = scanner.next();
        Integer deci = Integer.parseInt(hexa, 16);

        System.out.println(deci);
    }
}
