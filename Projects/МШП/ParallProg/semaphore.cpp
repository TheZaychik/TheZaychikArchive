#include <iostream>
#include <semaphore.h>

#define SEM_NAME "/my_semaphore_test"
using std::cout, std::cin, std::endl;

int main(int argc, char **argv) {
    sem_t *sem;
    sem = sem_open(SEM_NAME, O_CREAT, 0777, 1);
    if (sem == SEM_FAILED) {
        perror("sem_open");
        return 1;
    }
    cout << "Try to wait" << endl;
    sem_wait(sem);
    cout << "Critical section starts" << endl;
    int a;
    cin >> a;
    cout << a << endl;
    sem_post(sem); // увеличивет значение семафора на 1
    sem_close(sem);
    sem_unlink(SEM_NAME);
    return 0;
}