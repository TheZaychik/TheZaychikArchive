#include <iostream>
#include <random>
#include "cmath"
using namespace std;

void zad1(){
    int n,m;
    long buff;
    cout << "Введите n и m" << endl;
    cin >> n;
    cin >> m;
    cout << "Первчиный массив:" << endl;
    long a[n][m];
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            a[i][j] = -15 + rand() % 45;
            cout << a[i][j] << " ";
        }
        cout << endl;
    }
    for (int j = 0; j < m - 1; j++) {
        for (int i = 0; i < m - 1; i++) {  // sort
            if (a[n][i] >= a[n][i + 1]) {
                buff = a[n - 1][i];
                a[n][i] = a[n][i + 1];
                a[n][i + 1] = buff;
                for(int k = 0; k < n; k++){
                    buff = a[k][i];
                    a[k][i] = a[k][i+1];
                    a[k][i+1] = buff;
                }
            }
        }
    }
    cout << "Результирующий массив" << endl;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cout << a[i][j] << " ";
        }
        cout << endl;
    }
}

int main(){
    zad1();
    return 0;
}

