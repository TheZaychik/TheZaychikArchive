#include <iostream>
#include <unistd.h>
#include <sys/mman.h>
#include <fcntl.h>
using namespace std;

void* create_shared(size_t size) {
    int protection = PROT_READ | PROT_WRITE;
    int visibility = MAP_ANONYMOUS | MAP_SHARED;
    return mmap(NULL, size, protection, visibility, 0, 0);
}

int main() {
    int res = shm_open("my_memory", O_CREAT | O_RDWR, 0777);
    if (res == -1){
        cout << "Error at shm_open" << endl;
        return 1;
    }
    void* shmem = create_shared(sizeof(int));
    int* num = (int*)shmem;
    *num += 1;
    cout << *num << endl;
    for (int i = 0; i < 10; i++){
        int pid = fork();
        if (pid == 0){
            sleep(rnd);
            *num += 1;
            return 0;
        }
        cout << *num << endl;
    }
    return 0;
}


