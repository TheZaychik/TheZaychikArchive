#include <iostream>
#include <cstdlib>
#include <unistd.h>
#include <math.h>
#include <fstream>

using namespace std;

bool PNumber(int n) {
    fstream f;
    f.open("textfiles/kek.txt", ios::in | ios::out);
    int num;
    f >> num;
    cout << num << endl;
    for (int i = 2; i <= sqrt(n); i++)
        if (n % i == 0) {
            f << num;
            f.close();
            return false;
        }
        f << num + 1 << endl;
        f.close();
    return true;
}

int main() {
    int* mas = new int(5);
    int n, m, pid, status = 0;
    cout << "Enter number of input numbers: ";
    cin >> n;
    for (int i = 0; i < n; i++) {
        cout << "Enter number for check: " << endl;
        cin >> m;
        pid = fork();
        if (pid == 0) {
            if (PNumber(m)) {
                cout << m << " is prime number" << endl;
            } else {
                cout << m << " is not prime number" << endl;
            }
            return 0;
        }
        cout << "Process " << wait(&status) << " is ended" << endl;
    }
    return 0;
}