#include <iostream>
#include <unistd.h>
#include <sys/mman.h>

using namespace std;

void* create_shared(size_t size) {
    int protection = PROT_READ | PROT_WRITE;
    int visibility = MAP_ANONYMOUS | MAP_SHARED;
    return mmap(NULL, size, protection, visibility, 0, 0);
}

int main() {
    void* shmem = create_shared(sizeof(int));
    int* num = (int*)shmem;
    *num = 0;
    cout << *num << endl;
    int pid = fork();
    if (pid ==  0) {
        cout << "Incrementing num in child" << endl;
        *num += 1;
    } else {
        int status;
        int pid = wait(&status);
        if (status != 0) {
            cout << "Error" << endl;
            exit(0);
        }
        cout << *num << endl;
    }
    return 0;
}


