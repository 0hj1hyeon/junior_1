#include <pthread.h>
#include <stdio.h>
int sum; /* this data is shared by the thread(s) */
void* runner(void* param); /* the thread */
int main(int argc, char* argv[])
{
	pthread_t tid; /* the thread identifier */
	pthread_attr_t attr; /* set of thread attributes */
	if (argc != 2) {
		fprintf(stderr, "usage: a.out <integer value>\n");
		return -1;
	}
	if (atoi(argv[1]) < 0) {
		fprintf(stderr, "%d must be >= 0\n", atoi(argv[1]));
		return -1;
	}

	*get the default attributes* /
		pthread_attr_init(&attr);
	/* create the thread */
	pthread_create(&tid, &attr, runner, argv[1]);
	/* wait for the thread to exit */
	pthread_join(tid, NULL);
	printf("sum = %d\n", sum);
}
/* The thread will begin control in this function */
void* runner(void* param)
{
	int i, upper = atoi(param);
	sum = 0;
	for (i = 1; i <= upper; i++)
		sum += i;
	printf("Input any character to continue\n");
	getchar();
	pthread_exit(0);
}

// pthread2
/*#include <pthread.h>
#include <stdio.h>
int value = 0;
void *runner(void *param); /* the thread */
int main(int argc, char* argv[])
{
	int pid;
	pthread_t tid;
	pthread_attr_t attr;
	pid = fork();
	if (pid == 0) { /* child process */
		pthread_attr_init(&attr);
		pthread_create(&tid, &attr, runner, NULL);
		pthread_join(tid, NULL);
		printf("CHILD: value = %d\n", value); /* LINE C */
	}
	else if (pid > 0) { /* parent process */
		wait(NULL);
		printf("PARENT: value = %d\n", value); /* LINE P */
	}
}
void* runner(void* param)
{
	value = 5;
	printf("Input any character to continue\n");
	getchar();
	pthread_exit(0);
}
*/

