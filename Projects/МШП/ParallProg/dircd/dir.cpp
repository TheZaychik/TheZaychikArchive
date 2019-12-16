#include <iostream>
#include <cstdio>
#include <unistd.h>
#include <fstream>
#include <semaphore.h>
#include <sys/mman.h>
#include <fcntl.h>
#include <vector>

#define SEM_NAME "/dirfile_semaphore1"

using namespace std;

void *create_shared(size_t size) {
    int protection = PROT_READ | PROT_WRITE;
    int visibility = MAP_ANONYMOUS | MAP_SHARED;
    return mmap(NULL, size, protection, visibility, 0, 0);
}
// недопилено
int main() {
    vector<string> files;
    int sm_pr;
    cout << "Введите максимальное кол-во процессов: ";
    cin >> sm_pr;
    sem_t *sem;
    sem = sem_open(SEM_NAME, O_CREAT, 0777, sm_pr);
    if (sem == SEM_FAILED) {
        perror("sem_open");
        return 1;
    }
    int res = shm_open("my_memory", O_CREAT | O_RDWR, 0777);
    if (res == -1) {
        cout << "Error at shm_open" << endl;
        return 1;
    }
    FILE *p = popen("ls -p | grep -v /", "r");
    char *t = new char[1000];
    int status = fscanf(p, "%s", t);
    while (status != -1) {
        files.push_back(t);
        std::cout << t << std::endl;
        status = fscanf(p, "%s", t);
    }
    pclose(p);
    void *shmem = create_shared(sizeof(int));
    void *shmem2 = create_shared(sizeof(int));
    int *cf = (int *) shmem;
    int *uf = (int *) shmem2;
    *cf = 0;
    *uf = int(files.size());
    cout << "------------------" << endl;
    for (int i =0; i< files.size(); i++){
        cout << "Файлов завершено " << *cf << endl;
        cout << "Файлов осталось " << *uf << endl;
        sem_wait(sem);
        int pid = fork();
        if (pid == 0) {
            int str = 0;
            ifstream f(files[i]);
            cout << "У файла " << files[i];
            while (getline(f, files[i])) {
                str++;
            }
            cout << " " << str << " cтрок" << endl;
            f.close();
            *cf += 1;
            *uf -= 1;
            sem_post(sem);
            return 0;
        }
    }
    sem_close(sem);
    sem_unlink(SEM_NAME);
    return 0;
}