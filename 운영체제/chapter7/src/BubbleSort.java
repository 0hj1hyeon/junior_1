import java.util.Random;
import java.util.Scanner;

public class BubbleSort {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();
        // 배열의 크기 입력받기
        System.out.print("Enter the number of elements: ");
        int n = scanner.nextInt();
        // 배열 요소를 0부터 100까지의 랜덤 값으로 채우기
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            arr[i] = random.nextInt(101); // 0부터 100까지의 랜덤 정수
        }
        // 원래 배열 출력
        System.out.println("Original array:");
        for (int num : arr) {
            System.out.print(num + " ");
        }
        System.out.println();
        // 버블 정렬 수행
        int al = arr.length; // 배열의 크기
        for (int i = 0; i < al - 1; i++) {
            for (int j = 0; j < al - 1 - i; j++) {
                if (arr[j] > arr[j + 1]) {
                    // 요소 교환
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        // 정렬된 배열 출력
        System.out.println("Sorted array:");
        for (int num : arr) {
            System.out.print(num + " ");
        }
    }
}
