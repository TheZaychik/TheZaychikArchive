#include <iostream>
using namespace std;

int main() {
    int *mas = new int[5];
    mas[0] = 1;
    mas[1] = 3;
    mas[2] = 5;
    mas[3] = 7;
    mas[4] = 9;
    for (int i = 0; i < 5; i++) {
        cout << mas[i] << " " << &mas[i] << endl;
    }
    delete[] mas;
    return 0;
}
