import java.util.Scanner;

public class BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String trueFalse = scan.nextLine().trim();
        if (trueFalse.equals("True")) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
