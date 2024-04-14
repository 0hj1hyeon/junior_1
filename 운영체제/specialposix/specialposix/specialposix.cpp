// specialposix.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//


#define BUFFER_SIZE 10 // speicalcons.c
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <fcntl.h>
#include <sys/mman.h>
#include <unistd.h>
typedef struct {
    const char* name;
    const char* number;
}item;

item buffer[BUFFER_SIZE];
int in = 0;
int out = 0;

int main()
{
    const char* name = "jihyeon";
    const int SIZE = 4096;
    item next_produced;
    next_produced.name = "ohjihyeon";
    next_produced.number = "20204111";
    int shm_fd;
    void* ptr;
    int i;
    shm_fd = shm_open(name, O_RDONLY, 0666);
    if (shm_fd == -1) {
        printf("shared memory failed\n");
        exit(-1);
    }
    ptr = mmap(0, SIZE, PROT_READ, MAP_SHARED, shm_fd, 0);
    if (ptr == MAP_FAILED) {
        printf("Map failed\n");
        exit(-1);
    }

    item next_consumed;
    while (true) {
        while (in == out);
        next_consumed = buffer[out];
        out = (out + 1) % BUFFER_SIZE;
    }

}



/*#define BUFFER_SIZE 10 // specialprod.c
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <fcntl.h>
#include <sys/mman.h>
#include <unistd.h>
typedef struct {
    const char* name;
    const char* number;
}item;

item buffer[BUFFER_SIZE];
int in = 0;
int out = 0;

int main()
{
    const int SIZE = 4096;
    item next_produced;
    next_produced.name = "ohjihyeon";
    next_produced.number = "20204111";
    int shm_fd;
    void* ptr;
    shm_fd = shm_open(name, O_CREAT | O_RDWR, 0666);
    ftruncate(shm_fd, SIZE);
    ptr = mmap(0, SIZE, PROT_READ | PROT_WRITE, MAP_SHARED, shm_fd, 0);
    if (ptr == MAP_FAILED) {
        printf("Map failed\n");
        return -1;
    }
    memcpy(buffer, ptr, SIZE);

    while (true) {
        while (((in + 1) % BUFFER_SIZE) == out);
        buffer[in] = next_produced;
        in = (in + 1) % BUFFER_SIZE;
    }
}*/