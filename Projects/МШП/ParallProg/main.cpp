#include <iostream>
#include <cstdlib>
#include <unistd.h>
using namespace std;

int main() {
    // Задача: Есть список файлов, нужно подсчитать размер каждого файла
    // Так же посчитать общую сумму
    int a = fork(); // от англ. "вилка" - создание дочернего процесса
    cout << a << endl;
    if (a == 0)
        cout << "I am parent" << endl;
    else
        cout << "I am process with ID = " << a << endl;
    return 0;
}