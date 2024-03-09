#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <limits.h>

#define MAX 10001

typedef struct {
    int n, c;
} Counting;

typedef struct {
    int** adjList;
    bool* v;
    int* queue;
    int front, rear;
} Graph;

void initGraph(Graph* g) {
    int i;
    g->adjList = (int**)malloc(MAX * sizeof(int*));
    for (i = 0; i < MAX; i++) {
        g->adjList[i] = (int*)malloc(MAX * sizeof(int));
    }

    g->v = (bool*)malloc(MAX * sizeof(bool));
    g->queue = (int*)malloc(MAX * sizeof(int));

    for (i = 0; i < MAX; i++) {
        for (int j = 0; j < MAX; j++) {
            g->adjList[i][j] = 0;
        }
        g->v[i] = false;
    }

    g->front = g->rear = 0;
}

void addLink(Graph* g, int source, int destination) {
    g->adjList[source][destination] = 1;
    g->adjList[destination][source] = 1;
}

void generateGraph(Graph* g) {
    // Implementation of the generateGraph function in Java code
    // ...

}

void enqueue(Graph* g, int item) {
    g->queue[g->rear] = item;
    g->rear = (g->rear + 1) % MAX;
}

int dequeue(Graph* g) {
    int item = g->queue[g->front];
    g->front = (g->front + 1) % MAX;
    return item;
}

int bfs(Graph* g, int start, int arrive) {
    enqueue(g, start);
    g->v[start] = true;

    while (g->front != g->rear) {
        int player = dequeue(g);

        if (player == arrive) {
            return g->v[player];
        }

        for (int next = 1; next < MAX; next++) {
            if (g->adjList[player][next] && !g->v[next]) {
                g->v[next] = true;
                enqueue(g, next);
            }
        }
    }

    return -1;  // Indicates failure
}

int main() {
    Graph graph;
    initGraph(&graph);
    generateGraph(&graph);

    int T, start, arrive;
    scanf_s("%d", &T);

    for (int test_case = 1; test_case <= T; test_case++) {
        scanf_s("%d %d", &start, &arrive);
        printf("#%d %d\n", test_case, bfs(&graph, start, arrive));
    }

    // Free allocated memory
    for (int i = 0; i < MAX; i++) {
        free(graph.adjList[i]);
    }
    free(graph.adjList);
    free(graph.v);
    free(graph.queue);

    return 0;
}
