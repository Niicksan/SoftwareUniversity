import java.util.Arrays;
import java.util.Scanner;

public class LargestThreeNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] nums = Arrays
            .stream(scan.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        Arrays.sort(nums);
        int count = 0;
        for (int i = nums.length - 1; i >= 0 ; i--) {
            if (count == 3) {
                break;
            }
            System.out.println(nums[i]);
            count++;
        }
    }
}
