// 3_posix.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <sys/shm.h>
#include <sys/stat.h>
#include <sys/mman.h>

int main() {

    const int SIZE = 4096;
    const char* name = "OS";
    int fd;
    char* ptr;

    
    fd = shm_open(name, O_RDONLY, 0666);
    ptr =(char *)mmap(0, SIZE, PROT_READ | PROT_WRITE, MAP_SHARED, fd, 0);
    printf("%s", (char*)ptr);

    shm_unlink(name);

    return 0;

}
/* shprod.c
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <fcntl.h>
#include <sys/mman.h>
#include <unistd.h>
int main()
{
const int SIZE = 4096;
const char *name = "OS";
const char *message0= "Hello ";
const char *message1= "Soonchunhyang ";
const char *message2= "Computer Engineering and Science!\n";
int shm_fd;
void *ptr;
// create the shared memory segment 
shm_fd = shm_open(name, O_CREAT | O_RDWR, 0666);
//onfigure the size of the shared memory segment
ftruncate(shm_fd, SIZE);
// now map the shared memory segment in the address space of the process 
ptr = mmap(0, SIZE, PROT_READ | PROT_WRITE, MAP_SHARED, shm_fd, 0);
if (ptr == MAP_FAILED) {
    printf("Map failed\n");
    return -1;
}

//Now write to the shared memory region.

 //Note we must increment the value of ptr after each write.

sprintf(ptr, "%s", message0);
ptr += strlen(message0);
sprintf(ptr, "%s", message1);
ptr += strlen(message1);
sprintf(ptr, "%s", message2);
ptr += strlen(message2);
return 0;
}
*/


/* shcons.c
#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <sys/mman.h>
int main()
{
const char *name = "OS";
const int SIZE = 4096;
int shm_fd;
void *ptr;
int i;
// open the shared memory segment 
shm_fd = shm_open(name, O_RDONLY, 0666);
if (shm_fd == -1) {
    printf("shared memory failed\n");
    exit(-1);
}

//now map the shared memory segment in the address space of the process 
ptr = mmap(0, SIZE, PROT_READ, MAP_SHARED, shm_fd, 0);
if (ptr == MAP_FAILED) {
    printf("Map failed\n");
    exit(-1);
}
// now read from the shared memory region 
printf("%s", (char*)ptr);
// remove the shared memory segment 
if (shm_unlink(name) == -1) {
    printf("Error removing %s\n", name);
    exit(-1);
}
return 0;
}
*/


/* 그림 3.16
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <fcntl.h>
#include <sys/shm.h>
#include <sys/stat.h>
#include <sys/mman.h>

int main() {

    const int SIZE = 4096;
    const char* name = "OS";
    const char* message0 = "Hello ";
    const char* message1 = "World!";
    int fd;
    char* ptr;


    fd = shm_open(name, O_CREAT | O_RDWR, 0666);
    ftruncate(fd, SIZE);
    ptr =(char *)mmap(0, SIZE, PROT_READ | PROT_WRITE, MAP_SHARED, fd, 0);
    sprintf(ptr, "%s", message0);
    ptr += strlen(message0);
    sprintf(ptr, "%s", message1);
    ptr += strlen(message1);

    return 0;

}

*/

/* 그림 3.17
* #include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <sys/shm.h>
#include <sys/stat.h>
#include <sys/mman.h>

int main() {

    const int SIZE = 4096;
    const char* name = "OS";
    int fd;
    char* ptr;

    
    fd = shm_open(name, O_RDONLY, 0666);
    ptr =(char *)mmap(0, SIZE, PROT_READ | PROT_WRITE, MAP_SHARED, fd, 0);
    printf("%s", (char*)ptr);

    shm_unlink(name);

    return 0;

}

*/