public class gugudan {
    public static void main(String[] args) {
        // 구구단 결과를 저장할 2차원 배열 생성
        int[][] gugudan = new int[9][9];

        // 구구단 결과 계산 및 배열에 저장
        // 이 부분은 일반적인 for문을 사용합니다
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                gugudan[i][j] = (i + 1) * (j + 1);
            }
        }

        // 구구단 결과를 for each 문으로 출력
        int dan = 1;
        for (int[] row : gugudan) {
            System.out.println(dan + "단:");
            for (int result : row) {
                System.out.print(result + " ");
            }
            System.out.println();
            dan++;
        }
    }
}
