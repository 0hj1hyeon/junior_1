public class BankersAlgorithm {
    private int n = 5; // Number of processes
    private int m = 4; // Number of resources
    private int[] available = {1, 0, 0, 2}; // Available amount of each resource

    private int[][] maximum = {
            {0, 0, 1, 2},
            {1, 7, 5, 0},
            {2, 3, 5, 6},
            {0, 6, 5, 2},
            {0, 6, 5, 6}
    }; // Maximum demand of each process
    private int[][] allocation = {
            {0, 0, 1, 2},
            {1, 0, 0, 0},
            {1, 3, 5, 4},
            {0, 6, 3, 2},
            {0, 0, 1, 4}
    }; // Amount currently allocated to each process
    /*private int[][] maximum = {
            {5, 1, 1, 7},
            {3, 2, 1, 1},
            {3, 3, 2, 1},
            {4, 6, 1, 2},
            {6, 3, 2, 5}
    }; // Maximum demand of each process
    private int[][] allocation = {
            {3, 0, 1, 4},
            {2, 2, 1, 0},
            {3, 1, 2, 1},
            {0, 5, 1, 0},
            {4, 2, 1, 2}
    }; // Amount currently allocated to each process*/
    private int[][] need = new int[n][m]; // Remaining need of each process

    public BankersAlgorithm() {
        calculateNeed();
    }

    private void calculateNeed() {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                need[i][j] = maximum[i][j] - allocation[i][j];
            }
        }
    }

    public boolean isSafe() {
        int[] work = new int[m];
        boolean[] finish = new boolean[n];
        System.arraycopy(available, 0, work, 0, m);

        while (true) {
            boolean found = false;
            for (int i = 0; i < n; i++) {
                if (!finish[i]) {
                    boolean possible = true;
                    for (int j = 0; j < m; j++) {
                        if (need[i][j] > work[j]) {
                            possible = false;
                            break;
                        }
                    }
                    if (possible) {
                        for (int j = 0; j < m; j++) {
                            work[j] += allocation[i][j];
                        }
                        finish[i] = true;
                        found = true;
                    }
                }
            }
            if (!found) break;
        }

        for (boolean f : finish) {
            if (!f) return false;
        }
        return true;
    }

    public static void main(String[] args) {
        BankersAlgorithm ba = new BankersAlgorithm();

        if (ba.isSafe()) {
            System.out.println("The system is in a safe state.");
        } else {
            System.out.println("The system is not in a safe state.");
        }
    }
}

