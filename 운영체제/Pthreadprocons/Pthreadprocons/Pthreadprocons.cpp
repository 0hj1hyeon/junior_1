#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>

#define BUFFER_SIZE 10
typedef struct {
	int num;
}item;
item buffer[BUFFER_SIZE];
int in = 0;
int out = 0;
void* runner(); /* the thread */
int main(void)
{
	pthread_t tid; /* the thread identifier */
	pthread_attr_t attr; /* set of thread attributes */
	

	*get the default attributes* /
		pthread_attr_init(&attr);
	/* create the thread */
	pthread_create(&tid, &attr, runner, NULL);
	/* wait for the thread to exit */
	pthread_join(tid, NULL);
	for (i = 0; i < 10; i++) {
		if (in != out || (in + 1) % BUFFER_SIZE != out) {
			printf("num = %d\n", buffer[out].num);
			out = (out + 1) % BUFFER_SIZE;
		}
	}
}
/* The thread will begin control in this function */
void* runner()
{
	for (i = 0; i < 10; i++) {
		if (in != out && (in + 1) % BUFFER_SIZE != out) {
			item next_produced = { i };
			buffer[in] = next_produced;
			in = (in + 1) % BUFFER_SIZE;
		}
	}
		

	pthread_exit(0);
}